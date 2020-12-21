Module ModuloGlobal
    Public taFASES As New CXP_DSTableAdapters.GEN_CorreosFasesTableAdapter
    Public tFASES As New CXP_DS.GEN_CorreosFasesDataTable
    Public rFASES As CXP_DS.GEN_CorreosFasesRow
    Public taCorreos As New CXP_DSTableAdapters.GEN_Correos_SistemaFinagilTableAdapter
    Dim CorreoB As Boolean = False
    Dim Mensaje, MensajeAux, Asunto As String

    Public Function MandaCorreoFase(De As String, Fase As String, Asunto As String, Mensaje As String, Optional ByVal Archivo As String = "") As Boolean
        Asunto = Asunto.Trim
        MandaCorreoFase = False
        taFASES.Fill(tFASES, Fase)
        For Each rFASES In tFASES.Rows
            taCorreos.Insert(De, rFASES.Correo, Asunto, Mensaje, False, Date.Now, Archivo)
            MandaCorreoFase = True
        Next
        taFASES.Dispose()
        Return MandaCorreoFase
    End Function
    Public Sub EnviacORREO(ByVal Para As String, ByVal Mensaje As String, ByVal Asunto As String, de As String, Optional Archivo As String = "")
        taCorreos.Insert(de, Para, Asunto, Mensaje, False, Date.Now, Archivo)
        taCorreos.Dispose()
    End Sub

    Public Function SacaCorreoFase(Fase As String) As String
        SacaCorreoFase = ""
        taFASES.Fill(tFASES, Fase)
        For Each rFASES In tFASES.Rows
            SacaCorreoFase = rFASES.Correo
        Next
        Return SacaCorreoFase
    End Function
    Sub BorraDatos()
        Mensaje = ""
        Asunto = ""
        correoB = False
    End Sub

    Sub Inserta_CXP_MOVS_FACT()
        '1 Pendiente
        '2 VoboMC (usuario Factor libera o cambia importe)
        '3 MesaControl (Pasa pa MC)
        '4 AutorizadoMC
        '5 ErrorEnCuenta (MC, AUTMC)
        '6 Procesado (ya esta en CXP)
        '7 Rechazado (no paso a CXP)
        Dim CorreoMC As String = SacaCorreoFase("MCONTROL_CXP")
        Dim Aux() As String = CorreoMC.Split("<")
        Dim UsuarioMC() As String = Aux(1).Split("@")
        Dim ds As New CXP_DS
        Dim taCliFact As New CXP_DSTableAdapters.CXP_FactorClientesMCTableAdapter
        Dim TaPAg As New CXP_DSTableAdapters.CXP_PagosTesoreriaTableAdapter
        Dim taCuent As New CXP_DSTableAdapters.CXP_CuentasBancariasTableAdapter
        Dim taProv As New CXP_DSTableAdapters.CXP_ProveedoresTableAdapter
        Dim TaPags As New Factor100DSTableAdapters.Vw_PagosTableAdapter
        Dim tPags As New Factor100DS.Vw_PagosDataTable
        Dim rCta As CXP_DS.CXP_CuentasBancariasRow
        Dim cFecha As String = Today.ToString("yyyyMMdd")
        TaPags.UpdateMoneda()

        TaPags.Fill(tPags, "Pendiente")
        BorraDatos()
        For Each r As Factor100DS.Vw_PagosRow In tPags.Rows
            taCuent.Fill(ds.CXP_CuentasBancarias, r.clabe, r.rfc)
            If ds.CXP_CuentasBancarias.Rows.Count <= 0 Then
                MandaCorreoFase("Factoraje@cmoderna.com", "SISTEMAS_CXP", "Beneficiario sin cuenta bancaria o la cuenta no esta autorizada.", "ErrorEnCuenta: " & r.CL_NOMBRE & "-" & r.clabe)
                MandaCorreoFase("Factoraje@cmoderna.com", "FactorCXP", "Beneficiario sin cuenta bancaria o la cuenta no esta autorizada.", "ErrorEnCuenta: " & r.CL_NOMBRE & "-" & r.clabe)
                TaPags.UpdateEstatus("ErrorEnCuenta", r.id)
            Else
                taCliFact.Fill(ds.CXP_FactorClientesMC, r.cliente)
                If ds.CXP_FactorClientesMC.Rows.Count > 0 Then
                    TaPags.UpdateEstatus("VoboMC", r.id)
                Else
                    rCta = ds.CXP_CuentasBancarias.Rows(0)
                    Asunto = "Requiere Dispersión de FACTORAJE: " & Date.Now
                    CorreoB = True
                    Mensaje += "Solicitud: " & r.referencia & "<br>"
                    Mensaje += "Beneficiario: " & r.CL_NOMBRE & "<br>"
                    Mensaje += "Importe: " & CDec(r.importe).ToString("n2") & "<br><br>"
                    TaPAg.InsertPago("FAC", r.id, rCta.idCuentas, r.importe, Today.Date, Today.Date, r.moneda, Date.Now, r.referencia, rCta.idProveedor)
                    TaPags.UpdateEstatus("Procesado", r.id)
                End If
            End If
        Next
        If CorreoB = True Then
            MandaCorreoFase("Factoraje@cmoderna.com", "SISTEMAS_CXP", Asunto, Mensaje)
            MandaCorreoFase("Factoraje@cmoderna.com", "TESORERIA_CXP", Asunto, Mensaje)
        End If

        BorraDatos()
        TaPags.Fill(tPags, "MesaControl")
        For Each r As Factor100DS.Vw_PagosRow In tPags.Rows
            taCuent.Fill(ds.CXP_CuentasBancarias, r.clabe, r.rfc)
            If ds.CXP_CuentasBancarias.Rows.Count <= 0 Then
                MandaCorreoFase("Factoraje@cmoderna.com", "SISTEMAS_CXP", "Beneficiario sin cuenta bancaria o la cuenta no esta autorizada.", "ErrorEnCuentaMC: " & r.CL_NOMBRE & "-" & r.clabe)
                MandaCorreoFase("Factoraje@cmoderna.com", "FactorCXP", "Beneficiario sin cuenta bancaria o la cuenta no esta autorizada.", "ErrorEnCuentaMC: " & r.CL_NOMBRE & "-" & r.clabe)
                TaPags.UpdateEstatus("ErrorEnCuentaMC", r.id)
            Else
                taCliFact.Fill(ds.CXP_FactorClientesMC, r.cliente)
                If ds.CXP_FactorClientesMC.Rows.Count > 0 Then
                    CorreoB = True
                    Asunto = "Requiere autorizacion de FACTORAJE: " & Date.Now
                    Mensaje += "Solicitud: " & r.referencia & "<br>"
                    Mensaje += "Beneficiario: " & r.CL_NOMBRE & "<br>"
                    Mensaje += "Importe: " & CDec(r.importe).ToString("n2") & "<br>"
                    Mensaje += "<A HREF='https://finagil.com.mx/WEBtasas/5Afdb804-9cXp.aspx?User=" & UsuarioMC(0) & "&ID1=0'>Liga para Autorización.</A><br><br>"
                    TaPags.UpdateEstatus(UsuarioMC(0), r.id)
                Else
                    MensajeAux = "Solicitud: " & r.referencia & "<br>"
                    MensajeAux += "Beneficiario: " & r.CL_NOMBRE & "<br>"
                    MensajeAux += "Importe: " & CDec(r.importe).ToString("n2") & "<br>"
                    MandaCorreoFase("Factoraje@cmoderna.com", "SISTEMAS_CXP", "Solicitud en el LIMBO", MensajeAux)
                End If
            End If
        Next
        If CorreoB = True Then
            EnviacORREO(CorreoMC, Mensaje, Asunto, "Factoraje@cmoderna.com")
            MandaCorreoFase("Factoraje@cmoderna.com", "SISTEMAS_CXP", Asunto, Mensaje)
        End If
        'TaPags.Fill(tPags, "usuario MCONTROL_CXP") esto se hace manual desde wEB TASAS

        BorraDatos()
        TaPags.Fill(tPags, "AutorizadoMC")
        For Each r As Factor100DS.Vw_PagosRow In tPags.Rows
            taCuent.Fill(ds.CXP_CuentasBancarias, r.clabe, r.rfc)
            If ds.CXP_CuentasBancarias.Rows.Count <= 0 Then
                MandaCorreoFase("Factoraje@cmoderna.com", "SISTEMAS_CXP", "Beneficiario sin cuenta bancaria o la cuenta no esta autorizada. (vobo)", "ErrorEnCuentaMC2: " & r.cliente & "-" & r.clabe)
                MandaCorreoFase("Factoraje@cmoderna.com", "FactorCXP", "Beneficiario sin cuenta bancaria o la cuenta no esta autorizada.(vobo)", "ErrorEnCuentaMC2: " & r.cliente & "-" & r.clabe)
                TaPags.UpdateEstatus("ErrorEnCuentaAutMC", r.id)
            Else
                rCta = ds.CXP_CuentasBancarias.Rows(0)
                CorreoB = True
                Asunto = "Requiere Dispersión de FACTORAJE: " & Date.Now
                Mensaje += "Solicitud: " & r.referencia & "<br>"
                Mensaje += "Beneficiario: " & r.CL_NOMBRE & "<br>"
                Mensaje += "Importe: " & CDec(r.importe).ToString("n2") & "<br><br>"
                TaPAg.InsertPago("FAC", r.id, rCta.idCuentas, r.importe, Today.Date, Today.Date, r.moneda, Date.Now, r.referencia, rCta.idProveedor)
                TaPags.UpdateEstatus("Procesado", r.id)
            End If
        Next
        If CorreoB = True Then
            MandaCorreoFase("Factoraje@cmoderna.com", "SISTEMAS_CXP", Asunto, Mensaje)
            MandaCorreoFase("Factoraje@cmoderna.com", "TESORERIA_CXP", Asunto, Mensaje)
        End If
    End Sub
End Module
