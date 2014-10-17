Imports System.Data
Imports System.Data.SqlClient

Module Conexion
    Public Cjto_Orden1 As Cjto_Orden = New Cjto_Orden
    Public Cjto_Tablas1 As Cjto_Tablas = New Cjto_Tablas
    Public Cjto_Carta1 As Cjto_Carta = New Cjto_Carta
    Public Cjto_Resultados1 As Cjto_Resultados = New Cjto_Resultados
    Public Analisis1 As Analisis = New Analisis
    Public Auxiliar_OT, Contador_Dup, Auxiliar_Dup, NLabRevisionAnterior, Contador_De_Posicion, Contador_De_Posicion2, Orden_Trabajo, Orden_Trabajo_Bus, NLabFer, boton_notas_yemas, CodAnal, Ant_NLabDesde, Ant_NLabHasta, Ot_Num_Rev, NumLab_Rev, CodMuestraRev, Num_Factura, factura, forden_compra, banderacelular1, banderacelular2, banderafax1, banderafax2, banderafono1, banderafono2, cancelar As Integer
    Public ResultadosNLab, ResultadosCantidad, ResultadosMuestrayOrden As Integer
    'Public Conexion1 As String = "workstation id=DESARROLLO;packet size=4096;user id=sa;data source=HP-INF-SANDO;persist security info=True;initial catalog=LabSys;password=agrolito"
    'Public Conexion1_Real As String = "workstation id=DESARROLLO;packet size=4096;user id=sa;data source=HP-INF-SANDO;persist security info=True;initial catalog=LabSys;password=agrolito"

    'Public Conexion1 As String = "workstation id=DESARROLLO;packet size=4096;user id=sa;data source=SERVIDORAGROLAB;persist security info=True;initial catalog=Agrolab_prueba;password=sa"

    Public Conexion1 As String = "user id=sa;data source=AGROSERV;persist security info=True;initial catalog=agrolab_prueba;password=sa"
    Public Conexion1_Real As String = "workstation id=DESARROLLO;packet size=4096;user id=sa;data source=AGROSERV;persist security info=True;initial catalog=AGROLAB;password=sa"
    Public Modifica_Cod, Predio_Sis, Localidad_Sis, Digita_Testigo(6, 4), Digita_Estandar(6, 4), Obs1, Obs2, Seccion, Es_Planificacion, NumLab, Es_Modificacion, Ot_Num, codigo_de_area, fon, region_aux As String
    Public PMuestra, VAforo, VAlicuota, VAforoAlicuota, Normalidad, Chequeo, Ph, Temperatura, Potencia, Dilucion, Gasto, PFactor As Double
    Public Cambio_TabControl, Muestreador_Orden, Esta_Grabada_OT, TipoFacturacion, NotaDes1, NotaDes2, SeccionDes, Tipo_Carta, Elemento_Digitacion, FilaMarcaX, Estado, R_Social, direc, cond_pago, fcomuna, fgiro, ffono1, fciudad, frutfactura, fObsPago, fempresa As String
    Public Elemento, Nombre, Metodo As String
    Public CodAna, cantChKl, Creada As Integer
    Public Fila_Exp As Integer
    Public MATRIZ_OT(), MATRIZ_NLAB(), MATRIZ_NUMERODIGITACION(), MATRIZ_DUPLICADOS(), MATRIZ_NLAB2(), Boton_Notas, Muestra_Revision, Tej_Ed, FDectoPor, BanderaImprime, NoAdmitir, NoLimipiaRut, Lab As Integer
    Public Tejido_Foliar_Global, Edad_Foliar_Global, Tejido_Tejido_Global, Edad_Tejido_Global As String
    Public Revision_Digitacion, RutProd_Revision, Es_Revision, MATRIZ_ELEMENTOS(100), MATRIZ_ELEMENTOS_DESPLIEGUE(100), MATRIZ_ELEMENTOS_DESPLIEGUE2(100), MATRIZ_ELEMENTOS2(100), Matriz_Encabezado(100, 12), Matriz_Columnas(8, 4, 2) As String
    Public Fecha_emision As DateTime
    Public sWS_Id, sUserName, sPswd, sTipo, sPermisos, Historico As String
    Public bOK As Boolean = False
    
    Public Tipo_Ingreso_OT As String = "Normal"
    Public AuxSD_Dup As String
    Public Aux_Rut_Facturacion As String
    Public Fila_textura, Fila_QuiOrg, loc As Integer
    Public FechaHisDesde, FechaHisHasta As String
    Public ultimoNlab, guardaIndice As Integer
    Public srutadestPdf, guardadosAna As String
    '"
    '**** valores parametricos *************
    '
    Public Pa_Empresa, Pa_Iva, Pa_Ano, Pa_BasedeDato As String

    Public Sub Main()
      
    End Sub

End Module
