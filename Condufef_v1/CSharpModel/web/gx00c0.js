/**@preserve  GeneXus C# 10_3_15-115824 on 3/31/2022 0:19:57.38
*/
gx.evt.autoSkip=!1;gx.define("gx00c0",!1,function(){var n,t;this.ServerClass="gx00c0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV13petiquetasproductoid=gx.fn.getIntegerValue("vPETIQUETASPRODUCTOID",".");this.AV14petiquetascambsid=gx.fn.getIntegerValue("vPETIQUETASCAMBSID",".");this.AV15palmacenid=gx.fn.getIntegerValue("vPALMACENID",".")};this.e18251_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle"));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}])};this.e11251_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ETIQUETASPRODUCTOIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ETIQUETASPRODUCTOIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCETIQUETASPRODUCTOID","Visible",!0)):(gx.fn.setCtrlProperty("ETIQUETASPRODUCTOIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCETIQUETASPRODUCTOID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ETIQUETASPRODUCTOIDFILTERCONTAINER","Class")',ctrl:"ETIQUETASPRODUCTOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCETIQUETASPRODUCTOID","Visible")',ctrl:"vCETIQUETASPRODUCTOID",prop:"Visible"}])};this.e12251_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ETIQUETASCAMBSIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ETIQUETASCAMBSIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCETIQUETASCAMBSID","Visible",!0)):(gx.fn.setCtrlProperty("ETIQUETASCAMBSIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCETIQUETASCAMBSID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ETIQUETASCAMBSIDFILTERCONTAINER","Class")',ctrl:"ETIQUETASCAMBSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCETIQUETASCAMBSID","Visible")',ctrl:"vCETIQUETASCAMBSID",prop:"Visible"}])};this.e13251_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ALMACENIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ALMACENIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCALMACENID","Visible",!0)):(gx.fn.setCtrlProperty("ALMACENIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCALMACENID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ALMACENIDFILTERCONTAINER","Class")',ctrl:"ALMACENIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCALMACENID","Visible")',ctrl:"vCALMACENID",prop:"Visible"}])};this.e14251_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ETIQUETASNUMEROFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ETIQUETASNUMEROFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCETIQUETASNUMERO","Visible",!0)):(gx.fn.setCtrlProperty("ETIQUETASNUMEROFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCETIQUETASNUMERO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ETIQUETASNUMEROFILTERCONTAINER","Class")',ctrl:"ETIQUETASNUMEROFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCETIQUETASNUMERO","Visible")',ctrl:"vCETIQUETASNUMERO",prop:"Visible"}])};this.e15251_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ETIQUETASTATUSFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ETIQUETASTATUSFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCETIQUETASTATUS","Visible",!0)):(gx.fn.setCtrlProperty("ETIQUETASTATUSFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCETIQUETASTATUS","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ETIQUETASTATUSFILTERCONTAINER","Class")',ctrl:"ETIQUETASTATUSFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCETIQUETASTATUS","Visible")',ctrl:"vCETIQUETASTATUS",prop:"Visible"}])};this.e16251_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ETIQUETAFECHAREALIZADAFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("ETIQUETAFECHAREALIZADAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("ETIQUETAFECHAREALIZADAFILTERCONTAINER","Class","AdvancedContainerItem");this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ETIQUETAFECHAREALIZADAFILTERCONTAINER","Class")',ctrl:"ETIQUETAFECHAREALIZADAFILTERCONTAINER",prop:"Class"}])};this.e17251_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ETIQUETASREIMPRESIONFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ETIQUETASREIMPRESIONFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCETIQUETASREIMPRESION","Visible",!0)):(gx.fn.setCtrlProperty("ETIQUETASREIMPRESIONFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCETIQUETASREIMPRESION","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ETIQUETASREIMPRESIONFILTERCONTAINER","Class")',ctrl:"ETIQUETASREIMPRESIONFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCETIQUETASREIMPRESION","Visible")',ctrl:"vCETIQUETASREIMPRESION",prop:"Visible"}])};this.e21252_client=function(){this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e22251_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,82,83,85,86,87,88,89,90,91,92,93,94];this.GXLastCtrlId=94;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",84,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00c0",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",85,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(17,86,"ETIQUETASPRODUCTOID","productoid","","etiquetasproductoid","int",0,"px",9,9,"right",null,[],17,"etiquetasproductoid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(18,87,"ETIQUETASCAMBSID","cambsid","","etiquetascambsid","int",0,"px",9,9,"right",null,[],18,"etiquetascambsid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(19,88,"ALMACENID","almacenid","","almacenid","int",0,"px",9,9,"right",null,[],19,"almacenid",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(32,89,"ETIQUETASNUMERO","etiquetasnumero","","etiquetasnumero","int",0,"px",18,18,"right",null,[],32,"etiquetasnumero",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(33,90,"ETIQUETASTATUS","etiquetastatus","","etiquetastatus","int",0,"px",18,18,"right",null,[],33,"etiquetastatus",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(34,91,"ETIQUETAFECHAREALIZADA","etiquetafecharealizada","","etiquetafecharealizada","dtime",0,"px",19,19,"right",null,[],34,"etiquetafecharealizada",!0,8,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(35,92,"ETIQUETASREIMPRESION","etiquetasreimpresión","","etiquetasreimpresion","int",0,"px",18,18,"right",null,[],35,"etiquetasreimpresion",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.setGrid(t);n[2]={fld:"",grid:0};n[3]={fld:"MAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"ADVANCEDCONTAINER",grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"ETIQUETASPRODUCTOIDFILTERCONTAINER",grid:0};n[10]={fld:"",grid:0};n[11]={fld:"",grid:0};n[12]={fld:"LBLETIQUETASPRODUCTOIDFILTER",format:1,grid:0};n[13]={fld:"",grid:0};n[14]={fld:"",grid:0};n[15]={fld:"",grid:0};n[16]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCETIQUETASPRODUCTOID",gxz:"ZV6cetiquetasproductoid",gxold:"OV6cetiquetasproductoid",gxvar:"AV6cetiquetasproductoid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cetiquetasproductoid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cetiquetasproductoid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCETIQUETASPRODUCTOID",gx.O.AV6cetiquetasproductoid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cetiquetasproductoid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCETIQUETASPRODUCTOID",".")},nac:gx.falseFn};n[17]={fld:"",grid:0};n[18]={fld:"",grid:0};n[19]={fld:"ETIQUETASCAMBSIDFILTERCONTAINER",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={fld:"LBLETIQUETASCAMBSIDFILTER",format:1,grid:0};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCETIQUETASCAMBSID",gxz:"ZV7cetiquetascambsid",gxold:"OV7cetiquetascambsid",gxvar:"AV7cetiquetascambsid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cetiquetascambsid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7cetiquetascambsid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCETIQUETASCAMBSID",gx.O.AV7cetiquetascambsid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cetiquetascambsid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCETIQUETASCAMBSID",".")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"ALMACENIDFILTERCONTAINER",grid:0};n[30]={fld:"",grid:0};n[31]={fld:"",grid:0};n[32]={fld:"LBLALMACENIDFILTER",format:1,grid:0};n[33]={fld:"",grid:0};n[34]={fld:"",grid:0};n[35]={fld:"",grid:0};n[36]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCALMACENID",gxz:"ZV8calmacenid",gxold:"OV8calmacenid",gxvar:"AV8calmacenid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8calmacenid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV8calmacenid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCALMACENID",gx.O.AV8calmacenid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8calmacenid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCALMACENID",".")},nac:gx.falseFn};n[37]={fld:"",grid:0};n[38]={fld:"",grid:0};n[39]={fld:"ETIQUETASNUMEROFILTERCONTAINER",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={fld:"LBLETIQUETASNUMEROFILTER",format:1,grid:0};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCETIQUETASNUMERO",gxz:"ZV9cetiquetasnumero",gxold:"OV9cetiquetasnumero",gxvar:"AV9cetiquetasnumero",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9cetiquetasnumero=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV9cetiquetasnumero=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCETIQUETASNUMERO",gx.O.AV9cetiquetasnumero,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9cetiquetasnumero=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCETIQUETASNUMERO",".")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"ETIQUETASTATUSFILTERCONTAINER",grid:0};n[50]={fld:"",grid:0};n[51]={fld:"",grid:0};n[52]={fld:"LBLETIQUETASTATUSFILTER",format:1,grid:0};n[53]={fld:"",grid:0};n[54]={fld:"",grid:0};n[55]={fld:"",grid:0};n[56]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCETIQUETASTATUS",gxz:"ZV10cetiquetastatus",gxold:"OV10cetiquetastatus",gxvar:"AV10cetiquetastatus",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10cetiquetastatus=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV10cetiquetastatus=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCETIQUETASTATUS",gx.O.AV10cetiquetastatus,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10cetiquetastatus=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCETIQUETASTATUS",".")},nac:gx.falseFn};n[57]={fld:"",grid:0};n[58]={fld:"",grid:0};n[59]={fld:"ETIQUETAFECHAREALIZADAFILTERCONTAINER",grid:0};n[60]={fld:"",grid:0};n[61]={fld:"",grid:0};n[62]={fld:"LBLETIQUETAFECHAREALIZADAFILTER",format:1,grid:0};n[63]={fld:"",grid:0};n[64]={fld:"",grid:0};n[65]={fld:"",grid:0};n[66]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCETIQUETAFECHAREALIZADA",gxz:"ZV11cetiquetafecharealizada",gxold:"OV11cetiquetafecharealizada",gxvar:"AV11cetiquetafecharealizada",dp:{f:-1,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11cetiquetafecharealizada=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV11cetiquetafecharealizada=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCETIQUETAFECHAREALIZADA",gx.O.AV11cetiquetafecharealizada,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11cetiquetafecharealizada=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vCETIQUETAFECHAREALIZADA")},nac:gx.falseFn};n[67]={fld:"",grid:0};n[68]={fld:"",grid:0};n[69]={fld:"ETIQUETASREIMPRESIONFILTERCONTAINER",grid:0};n[70]={fld:"",grid:0};n[71]={fld:"",grid:0};n[72]={fld:"LBLETIQUETASREIMPRESIONFILTER",format:1,grid:0};n[73]={fld:"",grid:0};n[74]={fld:"",grid:0};n[75]={fld:"",grid:0};n[76]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCETIQUETASREIMPRESION",gxz:"ZV12cetiquetasreimpresion",gxold:"OV12cetiquetasreimpresion",gxvar:"AV12cetiquetasreimpresion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV12cetiquetasreimpresion=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV12cetiquetasreimpresion=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCETIQUETASREIMPRESION",gx.O.AV12cetiquetasreimpresion,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV12cetiquetasreimpresion=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCETIQUETASREIMPRESION",".")},nac:gx.falseFn};n[77]={fld:"",grid:0};n[78]={fld:"GRIDTABLE",grid:0};n[79]={fld:"",grid:0};n[80]={fld:"",grid:0};n[82]={fld:"",grid:0};n[83]={fld:"",grid:0};n[85]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84),gx.O.AV5LinkSelection,gx.O.AV19Linkselection_GXI)},c2v:function(){gx.O.AV19Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(84))},gxvar_GXI:"AV19Linkselection_GXI",nac:gx.falseFn};n[86]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ETIQUETASPRODUCTOID",gxz:"Z17etiquetasproductoid",gxold:"O17etiquetasproductoid",gxvar:"A17etiquetasproductoid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A17etiquetasproductoid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z17etiquetasproductoid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ETIQUETASPRODUCTOID",n||gx.fn.currentGridRowImpl(84),gx.O.A17etiquetasproductoid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A17etiquetasproductoid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ETIQUETASPRODUCTOID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[87]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ETIQUETASCAMBSID",gxz:"Z18etiquetascambsid",gxold:"O18etiquetascambsid",gxvar:"A18etiquetascambsid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A18etiquetascambsid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z18etiquetascambsid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ETIQUETASCAMBSID",n||gx.fn.currentGridRowImpl(84),gx.O.A18etiquetascambsid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A18etiquetascambsid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ETIQUETASCAMBSID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[88]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ALMACENID",gxz:"Z19almacenid",gxold:"O19almacenid",gxvar:"A19almacenid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A19almacenid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z19almacenid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ALMACENID",n||gx.fn.currentGridRowImpl(84),gx.O.A19almacenid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A19almacenid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ALMACENID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[89]={lvl:2,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ETIQUETASNUMERO",gxz:"Z32etiquetasnumero",gxold:"O32etiquetasnumero",gxvar:"A32etiquetasnumero",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A32etiquetasnumero=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z32etiquetasnumero=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ETIQUETASNUMERO",n||gx.fn.currentGridRowImpl(84),gx.O.A32etiquetasnumero,0)},c2v:function(){this.val()!==undefined&&(gx.O.A32etiquetasnumero=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ETIQUETASNUMERO",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[90]={lvl:2,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ETIQUETASTATUS",gxz:"Z33etiquetastatus",gxold:"O33etiquetastatus",gxvar:"A33etiquetastatus",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A33etiquetastatus=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z33etiquetastatus=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ETIQUETASTATUS",n||gx.fn.currentGridRowImpl(84),gx.O.A33etiquetastatus,0)},c2v:function(){this.val()!==undefined&&(gx.O.A33etiquetastatus=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ETIQUETASTATUS",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[91]={lvl:2,type:"dtime",len:10,dec:8,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ETIQUETAFECHAREALIZADA",gxz:"Z34etiquetafecharealizada",gxold:"O34etiquetafecharealizada",gxvar:"A34etiquetafecharealizada",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A34etiquetafecharealizada=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z34etiquetafecharealizada=gx.fn.toDatetimeValue(n))},v2c:function(n){gx.fn.setGridControlValue("ETIQUETAFECHAREALIZADA",n||gx.fn.currentGridRowImpl(84),gx.O.A34etiquetafecharealizada,0)},c2v:function(){this.val()!==undefined&&(gx.O.A34etiquetafecharealizada=gx.fn.toDatetimeValue(this.val()))},val:function(n){return gx.fn.getGridDateTimeValue("ETIQUETAFECHAREALIZADA",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[92]={lvl:2,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ETIQUETASREIMPRESION",gxz:"Z35etiquetasreimpresion",gxold:"O35etiquetasreimpresion",gxvar:"A35etiquetasreimpresion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A35etiquetasreimpresion=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z35etiquetasreimpresion=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ETIQUETASREIMPRESION",n||gx.fn.currentGridRowImpl(84),gx.O.A35etiquetasreimpresion,0)},c2v:function(){this.val()!==undefined&&(gx.O.A35etiquetasreimpresion=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ETIQUETASREIMPRESION",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[93]={fld:"",grid:0};n[94]={fld:"",grid:0};this.AV6cetiquetasproductoid=0;this.ZV6cetiquetasproductoid=0;this.OV6cetiquetasproductoid=0;this.AV7cetiquetascambsid=0;this.ZV7cetiquetascambsid=0;this.OV7cetiquetascambsid=0;this.AV8calmacenid=0;this.ZV8calmacenid=0;this.OV8calmacenid=0;this.AV9cetiquetasnumero=0;this.ZV9cetiquetasnumero=0;this.OV9cetiquetasnumero=0;this.AV10cetiquetastatus=0;this.ZV10cetiquetastatus=0;this.OV10cetiquetastatus=0;this.AV11cetiquetafecharealizada=gx.date.nullDate();this.ZV11cetiquetafecharealizada=gx.date.nullDate();this.OV11cetiquetafecharealizada=gx.date.nullDate();this.AV12cetiquetasreimpresion=0;this.ZV12cetiquetasreimpresion=0;this.OV12cetiquetasreimpresion=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z17etiquetasproductoid=0;this.O17etiquetasproductoid=0;this.Z18etiquetascambsid=0;this.O18etiquetascambsid=0;this.Z19almacenid=0;this.O19almacenid=0;this.Z32etiquetasnumero=0;this.O32etiquetasnumero=0;this.Z33etiquetastatus=0;this.O33etiquetastatus=0;this.Z34etiquetafecharealizada=gx.date.nullDate();this.O34etiquetafecharealizada=gx.date.nullDate();this.Z35etiquetasreimpresion=0;this.O35etiquetasreimpresion=0;this.AV6cetiquetasproductoid=0;this.AV7cetiquetascambsid=0;this.AV8calmacenid=0;this.AV9cetiquetasnumero=0;this.AV10cetiquetastatus=0;this.AV11cetiquetafecharealizada=gx.date.nullDate();this.AV12cetiquetasreimpresion=0;this.AV13petiquetasproductoid=0;this.AV14petiquetascambsid=0;this.AV15palmacenid=0;this.AV5LinkSelection="";this.A17etiquetasproductoid=0;this.A18etiquetascambsid=0;this.A19almacenid=0;this.A32etiquetasnumero=0;this.A33etiquetastatus=0;this.A34etiquetafecharealizada=gx.date.nullDate();this.A35etiquetasreimpresion=0;this.Events={e21252_client:["ENTER",!0],e22251_client:["CANCEL",!0],e18251_client:["'TOGGLE'",!1],e11251_client:["LBLETIQUETASPRODUCTOIDFILTER.CLICK",!1],e12251_client:["LBLETIQUETASCAMBSIDFILTER.CLICK",!1],e13251_client:["LBLALMACENIDFILTER.CLICK",!1],e14251_client:["LBLETIQUETASNUMEROFILTER.CLICK",!1],e15251_client:["LBLETIQUETASTATUSFILTER.CLICK",!1],e16251_client:["LBLETIQUETAFECHAREALIZADAFILTER.CLICK",!1],e17251_client:["LBLETIQUETASREIMPRESIONFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cetiquetasproductoid",fld:"vCETIQUETASPRODUCTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cetiquetascambsid",fld:"vCETIQUETASCAMBSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8calmacenid",fld:"vCALMACENID",pic:"ZZZZZZZZ9",nv:0},{av:"AV9cetiquetasnumero",fld:"vCETIQUETASNUMERO",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10cetiquetastatus",fld:"vCETIQUETASTATUS",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11cetiquetafecharealizada",fld:"vCETIQUETAFECHAREALIZADA",pic:"99/99/9999 99:99:99",nv:""},{av:"AV12cetiquetasreimpresion",fld:"vCETIQUETASREIMPRESION",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLETIQUETASPRODUCTOIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ETIQUETASPRODUCTOIDFILTERCONTAINER","Class")',ctrl:"ETIQUETASPRODUCTOIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ETIQUETASPRODUCTOIDFILTERCONTAINER","Class")',ctrl:"ETIQUETASPRODUCTOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCETIQUETASPRODUCTOID","Visible")',ctrl:"vCETIQUETASPRODUCTOID",prop:"Visible"}]];this.EvtParms["LBLETIQUETASCAMBSIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ETIQUETASCAMBSIDFILTERCONTAINER","Class")',ctrl:"ETIQUETASCAMBSIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ETIQUETASCAMBSIDFILTERCONTAINER","Class")',ctrl:"ETIQUETASCAMBSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCETIQUETASCAMBSID","Visible")',ctrl:"vCETIQUETASCAMBSID",prop:"Visible"}]];this.EvtParms["LBLALMACENIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ALMACENIDFILTERCONTAINER","Class")',ctrl:"ALMACENIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ALMACENIDFILTERCONTAINER","Class")',ctrl:"ALMACENIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCALMACENID","Visible")',ctrl:"vCALMACENID",prop:"Visible"}]];this.EvtParms["LBLETIQUETASNUMEROFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ETIQUETASNUMEROFILTERCONTAINER","Class")',ctrl:"ETIQUETASNUMEROFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ETIQUETASNUMEROFILTERCONTAINER","Class")',ctrl:"ETIQUETASNUMEROFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCETIQUETASNUMERO","Visible")',ctrl:"vCETIQUETASNUMERO",prop:"Visible"}]];this.EvtParms["LBLETIQUETASTATUSFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ETIQUETASTATUSFILTERCONTAINER","Class")',ctrl:"ETIQUETASTATUSFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ETIQUETASTATUSFILTERCONTAINER","Class")',ctrl:"ETIQUETASTATUSFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCETIQUETASTATUS","Visible")',ctrl:"vCETIQUETASTATUS",prop:"Visible"}]];this.EvtParms["LBLETIQUETAFECHAREALIZADAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ETIQUETAFECHAREALIZADAFILTERCONTAINER","Class")',ctrl:"ETIQUETAFECHAREALIZADAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ETIQUETAFECHAREALIZADAFILTERCONTAINER","Class")',ctrl:"ETIQUETAFECHAREALIZADAFILTERCONTAINER",prop:"Class"}]];this.EvtParms["LBLETIQUETASREIMPRESIONFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ETIQUETASREIMPRESIONFILTERCONTAINER","Class")',ctrl:"ETIQUETASREIMPRESIONFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ETIQUETASREIMPRESIONFILTERCONTAINER","Class")',ctrl:"ETIQUETASREIMPRESIONFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCETIQUETASREIMPRESION","Visible")',ctrl:"vCETIQUETASREIMPRESION",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A17etiquetasproductoid",fld:"ETIQUETASPRODUCTOID",pic:"ZZZZZZZZ9",hsh:!0,nv:0},{av:"A18etiquetascambsid",fld:"ETIQUETASCAMBSID",pic:"ZZZZZZZZ9",hsh:!0,nv:0},{av:"A19almacenid",fld:"ALMACENID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV13petiquetasproductoid",fld:"vPETIQUETASPRODUCTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV14petiquetascambsid",fld:"vPETIQUETASCAMBSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV15palmacenid",fld:"vPALMACENID",pic:"ZZZZZZZZ9",nv:0}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cetiquetasproductoid",fld:"vCETIQUETASPRODUCTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cetiquetascambsid",fld:"vCETIQUETASCAMBSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8calmacenid",fld:"vCALMACENID",pic:"ZZZZZZZZ9",nv:0},{av:"AV9cetiquetasnumero",fld:"vCETIQUETASNUMERO",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10cetiquetastatus",fld:"vCETIQUETASTATUS",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11cetiquetafecharealizada",fld:"vCETIQUETAFECHAREALIZADA",pic:"99/99/9999 99:99:99",nv:""},{av:"AV12cetiquetasreimpresion",fld:"vCETIQUETASREIMPRESION",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cetiquetasproductoid",fld:"vCETIQUETASPRODUCTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cetiquetascambsid",fld:"vCETIQUETASCAMBSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8calmacenid",fld:"vCALMACENID",pic:"ZZZZZZZZ9",nv:0},{av:"AV9cetiquetasnumero",fld:"vCETIQUETASNUMERO",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10cetiquetastatus",fld:"vCETIQUETASTATUS",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11cetiquetafecharealizada",fld:"vCETIQUETAFECHAREALIZADA",pic:"99/99/9999 99:99:99",nv:""},{av:"AV12cetiquetasreimpresion",fld:"vCETIQUETASREIMPRESION",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cetiquetasproductoid",fld:"vCETIQUETASPRODUCTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cetiquetascambsid",fld:"vCETIQUETASCAMBSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8calmacenid",fld:"vCALMACENID",pic:"ZZZZZZZZ9",nv:0},{av:"AV9cetiquetasnumero",fld:"vCETIQUETASNUMERO",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10cetiquetastatus",fld:"vCETIQUETASTATUS",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11cetiquetafecharealizada",fld:"vCETIQUETAFECHAREALIZADA",pic:"99/99/9999 99:99:99",nv:""},{av:"AV12cetiquetasreimpresion",fld:"vCETIQUETASREIMPRESION",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cetiquetasproductoid",fld:"vCETIQUETASPRODUCTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cetiquetascambsid",fld:"vCETIQUETASCAMBSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8calmacenid",fld:"vCALMACENID",pic:"ZZZZZZZZ9",nv:0},{av:"AV9cetiquetasnumero",fld:"vCETIQUETASNUMERO",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10cetiquetastatus",fld:"vCETIQUETASTATUS",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11cetiquetafecharealizada",fld:"vCETIQUETAFECHAREALIZADA",pic:"99/99/9999 99:99:99",nv:""},{av:"AV12cetiquetasreimpresion",fld:"vCETIQUETASREIMPRESION",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}],[]];this.setVCMap("AV13petiquetasproductoid","vPETIQUETASPRODUCTOID",0,"int");this.setVCMap("AV14petiquetascambsid","vPETIQUETASCAMBSID",0,"int");this.setVCMap("AV15palmacenid","vPALMACENID",0,"int");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar(this.GXValidFnc[66]);t.addRefreshingVar(this.GXValidFnc[76]);this.InitStandaloneVars()});gx.createParentObj(gx00c0)