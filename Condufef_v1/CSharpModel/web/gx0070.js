/**@preserve  GeneXus C# 10_3_15-115824 on 1/29/2022 0:1:0.28
*/
gx.evt.autoSkip=!1;gx.define("gx0070",!1,function(){var n,t;this.ServerClass="gx0070";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV13pestatusarticuloid=gx.fn.getIntegerValue("vPESTATUSARTICULOID",".")};this.e181w1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle"));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}])};this.e111w1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ESTATUSARTICULOIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ESTATUSARTICULOIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCESTATUSARTICULOID","Visible",!0)):(gx.fn.setCtrlProperty("ESTATUSARTICULOIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCESTATUSARTICULOID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ESTATUSARTICULOIDFILTERCONTAINER","Class")',ctrl:"ESTATUSARTICULOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCESTATUSARTICULOID","Visible")',ctrl:"vCESTATUSARTICULOID",prop:"Visible"}])};this.e121w1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ESTATUSARTICULODSCFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ESTATUSARTICULODSCFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCESTATUSARTICULODSC","Visible",!0)):(gx.fn.setCtrlProperty("ESTATUSARTICULODSCFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCESTATUSARTICULODSC","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ESTATUSARTICULODSCFILTERCONTAINER","Class")',ctrl:"ESTATUSARTICULODSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCESTATUSARTICULODSC","Visible")',ctrl:"vCESTATUSARTICULODSC",prop:"Visible"}])};this.e131w1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ESTATUSARTICULODESCUSOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ESTATUSARTICULODESCUSOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCESTATUSARTICULODESCUSO","Visible",!0)):(gx.fn.setCtrlProperty("ESTATUSARTICULODESCUSOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCESTATUSARTICULODESCUSO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ESTATUSARTICULODESCUSOFILTERCONTAINER","Class")',ctrl:"ESTATUSARTICULODESCUSOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCESTATUSARTICULODESCUSO","Visible")',ctrl:"vCESTATUSARTICULODESCUSO",prop:"Visible"}])};this.e141w1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ESTATUSARTICULOAPLICAMOVFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ESTATUSARTICULOAPLICAMOVFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCESTATUSARTICULOAPLICAMOV","Visible",!0)):(gx.fn.setCtrlProperty("ESTATUSARTICULOAPLICAMOVFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCESTATUSARTICULOAPLICAMOV","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ESTATUSARTICULOAPLICAMOVFILTERCONTAINER","Class")',ctrl:"ESTATUSARTICULOAPLICAMOVFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCESTATUSARTICULOAPLICAMOV","Visible")',ctrl:"vCESTATUSARTICULOAPLICAMOV",prop:"Visible"}])};this.e151w1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ESTATUSARTICULOUSOTABLAFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ESTATUSARTICULOUSOTABLAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCESTATUSARTICULOUSOTABLA","Visible",!0)):(gx.fn.setCtrlProperty("ESTATUSARTICULOUSOTABLAFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCESTATUSARTICULOUSOTABLA","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ESTATUSARTICULOUSOTABLAFILTERCONTAINER","Class")',ctrl:"ESTATUSARTICULOUSOTABLAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCESTATUSARTICULOUSOTABLA","Visible")',ctrl:"vCESTATUSARTICULOUSOTABLA",prop:"Visible"}])};this.e161w1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ESTATUSARTICULOUSUARIOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ESTATUSARTICULOUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCESTATUSARTICULOUSUARIO","Visible",!0)):(gx.fn.setCtrlProperty("ESTATUSARTICULOUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCESTATUSARTICULOUSUARIO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ESTATUSARTICULOUSUARIOFILTERCONTAINER","Class")',ctrl:"ESTATUSARTICULOUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCESTATUSARTICULOUSUARIO","Visible")',ctrl:"vCESTATUSARTICULOUSUARIO",prop:"Visible"}])};this.e171w1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ESTATUSARTICULOFECREGFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("ESTATUSARTICULOFECREGFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("ESTATUSARTICULOFECREGFILTERCONTAINER","Class","AdvancedContainerItem");this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ESTATUSARTICULOFECREGFILTERCONTAINER","Class")',ctrl:"ESTATUSARTICULOFECREGFILTERCONTAINER",prop:"Class"}])};this.e211w2_client=function(){this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e221w1_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,82,83,85,86,87,88,89];this.GXLastCtrlId=89;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",84,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0070",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",85,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(12,86,"ESTATUSARTICULOID","estatusarticuloid","","estatusarticuloid","int",0,"px",18,18,"right",null,[],12,"estatusarticuloid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(54,87,"ESTATUSARTICULODSC","estatusarticulodsc","","estatusarticulodsc","svchar",0,"px",100,80,"left",null,[],54,"estatusarticulodsc",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");this.setGrid(t);n[2]={fld:"",grid:0};n[3]={fld:"MAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"ADVANCEDCONTAINER",grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"ESTATUSARTICULOIDFILTERCONTAINER",grid:0};n[10]={fld:"",grid:0};n[11]={fld:"",grid:0};n[12]={fld:"LBLESTATUSARTICULOIDFILTER",format:1,grid:0};n[13]={fld:"",grid:0};n[14]={fld:"",grid:0};n[15]={fld:"",grid:0};n[16]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCESTATUSARTICULOID",gxz:"ZV6cestatusarticuloid",gxold:"OV6cestatusarticuloid",gxvar:"AV6cestatusarticuloid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cestatusarticuloid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cestatusarticuloid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCESTATUSARTICULOID",gx.O.AV6cestatusarticuloid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cestatusarticuloid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCESTATUSARTICULOID",".")},nac:gx.falseFn};n[17]={fld:"",grid:0};n[18]={fld:"",grid:0};n[19]={fld:"ESTATUSARTICULODSCFILTERCONTAINER",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={fld:"LBLESTATUSARTICULODSCFILTER",format:1,grid:0};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCESTATUSARTICULODSC",gxz:"ZV7cestatusarticulodsc",gxold:"OV7cestatusarticulodsc",gxvar:"AV7cestatusarticulodsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cestatusarticulodsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cestatusarticulodsc=n)},v2c:function(){gx.fn.setControlValue("vCESTATUSARTICULODSC",gx.O.AV7cestatusarticulodsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cestatusarticulodsc=this.val())},val:function(){return gx.fn.getControlValue("vCESTATUSARTICULODSC")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"ESTATUSARTICULODESCUSOFILTERCONTAINER",grid:0};n[30]={fld:"",grid:0};n[31]={fld:"",grid:0};n[32]={fld:"LBLESTATUSARTICULODESCUSOFILTER",format:1,grid:0};n[33]={fld:"",grid:0};n[34]={fld:"",grid:0};n[35]={fld:"",grid:0};n[36]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCESTATUSARTICULODESCUSO",gxz:"ZV8cestatusarticulodescuso",gxold:"OV8cestatusarticulodescuso",gxvar:"AV8cestatusarticulodescuso",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cestatusarticulodescuso=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cestatusarticulodescuso=n)},v2c:function(){gx.fn.setControlValue("vCESTATUSARTICULODESCUSO",gx.O.AV8cestatusarticulodescuso,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cestatusarticulodescuso=this.val())},val:function(){return gx.fn.getControlValue("vCESTATUSARTICULODESCUSO")},nac:gx.falseFn};n[37]={fld:"",grid:0};n[38]={fld:"",grid:0};n[39]={fld:"ESTATUSARTICULOAPLICAMOVFILTERCONTAINER",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={fld:"LBLESTATUSARTICULOAPLICAMOVFILTER",format:1,grid:0};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCESTATUSARTICULOAPLICAMOV",gxz:"ZV9cestatusarticuloaplicamov",gxold:"OV9cestatusarticuloaplicamov",gxvar:"AV9cestatusarticuloaplicamov",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9cestatusarticuloaplicamov=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV9cestatusarticuloaplicamov=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCESTATUSARTICULOAPLICAMOV",gx.O.AV9cestatusarticuloaplicamov,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9cestatusarticuloaplicamov=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCESTATUSARTICULOAPLICAMOV",".")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"ESTATUSARTICULOUSOTABLAFILTERCONTAINER",grid:0};n[50]={fld:"",grid:0};n[51]={fld:"",grid:0};n[52]={fld:"LBLESTATUSARTICULOUSOTABLAFILTER",format:1,grid:0};n[53]={fld:"",grid:0};n[54]={fld:"",grid:0};n[55]={fld:"",grid:0};n[56]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCESTATUSARTICULOUSOTABLA",gxz:"ZV10cestatusarticulousotabla",gxold:"OV10cestatusarticulousotabla",gxvar:"AV10cestatusarticulousotabla",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10cestatusarticulousotabla=n)},v2z:function(n){n!==undefined&&(gx.O.ZV10cestatusarticulousotabla=n)},v2c:function(){gx.fn.setControlValue("vCESTATUSARTICULOUSOTABLA",gx.O.AV10cestatusarticulousotabla,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10cestatusarticulousotabla=this.val())},val:function(){return gx.fn.getControlValue("vCESTATUSARTICULOUSOTABLA")},nac:gx.falseFn};n[57]={fld:"",grid:0};n[58]={fld:"",grid:0};n[59]={fld:"ESTATUSARTICULOUSUARIOFILTERCONTAINER",grid:0};n[60]={fld:"",grid:0};n[61]={fld:"",grid:0};n[62]={fld:"LBLESTATUSARTICULOUSUARIOFILTER",format:1,grid:0};n[63]={fld:"",grid:0};n[64]={fld:"",grid:0};n[65]={fld:"",grid:0};n[66]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCESTATUSARTICULOUSUARIO",gxz:"ZV11cestatusarticulousuario",gxold:"OV11cestatusarticulousuario",gxvar:"AV11cestatusarticulousuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11cestatusarticulousuario=n)},v2z:function(n){n!==undefined&&(gx.O.ZV11cestatusarticulousuario=n)},v2c:function(){gx.fn.setControlValue("vCESTATUSARTICULOUSUARIO",gx.O.AV11cestatusarticulousuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11cestatusarticulousuario=this.val())},val:function(){return gx.fn.getControlValue("vCESTATUSARTICULOUSUARIO")},nac:gx.falseFn};n[67]={fld:"",grid:0};n[68]={fld:"",grid:0};n[69]={fld:"ESTATUSARTICULOFECREGFILTERCONTAINER",grid:0};n[70]={fld:"",grid:0};n[71]={fld:"",grid:0};n[72]={fld:"LBLESTATUSARTICULOFECREGFILTER",format:1,grid:0};n[73]={fld:"",grid:0};n[74]={fld:"",grid:0};n[75]={fld:"",grid:0};n[76]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCESTATUSARTICULOFECREG",gxz:"ZV12cestatusarticulofecreg",gxold:"OV12cestatusarticulofecreg",gxvar:"AV12cestatusarticulofecreg",dp:{f:-1,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV12cestatusarticulofecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV12cestatusarticulofecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCESTATUSARTICULOFECREG",gx.O.AV12cestatusarticulofecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV12cestatusarticulofecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vCESTATUSARTICULOFECREG")},nac:gx.falseFn};n[77]={fld:"",grid:0};n[78]={fld:"GRIDTABLE",grid:0};n[79]={fld:"",grid:0};n[80]={fld:"",grid:0};n[82]={fld:"",grid:0};n[83]={fld:"",grid:0};n[85]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84),gx.O.AV5LinkSelection,gx.O.AV17Linkselection_GXI)},c2v:function(){gx.O.AV17Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(84))},gxvar_GXI:"AV17Linkselection_GXI",nac:gx.falseFn};n[86]={lvl:2,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ESTATUSARTICULOID",gxz:"Z12estatusarticuloid",gxold:"O12estatusarticuloid",gxvar:"A12estatusarticuloid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A12estatusarticuloid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z12estatusarticuloid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ESTATUSARTICULOID",n||gx.fn.currentGridRowImpl(84),gx.O.A12estatusarticuloid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A12estatusarticuloid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ESTATUSARTICULOID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[87]={lvl:2,type:"svchar",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ESTATUSARTICULODSC",gxz:"Z54estatusarticulodsc",gxold:"O54estatusarticulodsc",gxvar:"A54estatusarticulodsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A54estatusarticulodsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z54estatusarticulodsc=n)},v2c:function(n){gx.fn.setGridControlValue("ESTATUSARTICULODSC",n||gx.fn.currentGridRowImpl(84),gx.O.A54estatusarticulodsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A54estatusarticulodsc=this.val())},val:function(n){return gx.fn.getGridControlValue("ESTATUSARTICULODSC",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[88]={fld:"",grid:0};n[89]={fld:"",grid:0};this.AV6cestatusarticuloid=0;this.ZV6cestatusarticuloid=0;this.OV6cestatusarticuloid=0;this.AV7cestatusarticulodsc="";this.ZV7cestatusarticulodsc="";this.OV7cestatusarticulodsc="";this.AV8cestatusarticulodescuso="";this.ZV8cestatusarticulodescuso="";this.OV8cestatusarticulodescuso="";this.AV9cestatusarticuloaplicamov=0;this.ZV9cestatusarticuloaplicamov=0;this.OV9cestatusarticuloaplicamov=0;this.AV10cestatusarticulousotabla="";this.ZV10cestatusarticulousotabla="";this.OV10cestatusarticulousotabla="";this.AV11cestatusarticulousuario="";this.ZV11cestatusarticulousuario="";this.OV11cestatusarticulousuario="";this.AV12cestatusarticulofecreg=gx.date.nullDate();this.ZV12cestatusarticulofecreg=gx.date.nullDate();this.OV12cestatusarticulofecreg=gx.date.nullDate();this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z12estatusarticuloid=0;this.O12estatusarticuloid=0;this.Z54estatusarticulodsc="";this.O54estatusarticulodsc="";this.AV6cestatusarticuloid=0;this.AV7cestatusarticulodsc="";this.AV8cestatusarticulodescuso="";this.AV9cestatusarticuloaplicamov=0;this.AV10cestatusarticulousotabla="";this.AV11cestatusarticulousuario="";this.AV12cestatusarticulofecreg=gx.date.nullDate();this.AV13pestatusarticuloid=0;this.A59estatusarticulofecreg=gx.date.nullDate();this.A58estatusarticulousuario="";this.A57estatusarticulousotabla="";this.A56estatusarticuloaplicamov=0;this.A55estatusarticulodescuso="";this.AV5LinkSelection="";this.A12estatusarticuloid=0;this.A54estatusarticulodsc="";this.Events={e211w2_client:["ENTER",!0],e221w1_client:["CANCEL",!0],e181w1_client:["'TOGGLE'",!1],e111w1_client:["LBLESTATUSARTICULOIDFILTER.CLICK",!1],e121w1_client:["LBLESTATUSARTICULODSCFILTER.CLICK",!1],e131w1_client:["LBLESTATUSARTICULODESCUSOFILTER.CLICK",!1],e141w1_client:["LBLESTATUSARTICULOAPLICAMOVFILTER.CLICK",!1],e151w1_client:["LBLESTATUSARTICULOUSOTABLAFILTER.CLICK",!1],e161w1_client:["LBLESTATUSARTICULOUSUARIOFILTER.CLICK",!1],e171w1_client:["LBLESTATUSARTICULOFECREGFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cestatusarticuloid",fld:"vCESTATUSARTICULOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7cestatusarticulodsc",fld:"vCESTATUSARTICULODSC",pic:"",nv:""},{av:"AV8cestatusarticulodescuso",fld:"vCESTATUSARTICULODESCUSO",pic:"",nv:""},{av:"AV9cestatusarticuloaplicamov",fld:"vCESTATUSARTICULOAPLICAMOV",pic:"ZZZZZZZZ9",nv:0},{av:"AV10cestatusarticulousotabla",fld:"vCESTATUSARTICULOUSOTABLA",pic:"",nv:""},{av:"AV11cestatusarticulousuario",fld:"vCESTATUSARTICULOUSUARIO",pic:"",nv:""},{av:"AV12cestatusarticulofecreg",fld:"vCESTATUSARTICULOFECREG",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLESTATUSARTICULOIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ESTATUSARTICULOIDFILTERCONTAINER","Class")',ctrl:"ESTATUSARTICULOIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ESTATUSARTICULOIDFILTERCONTAINER","Class")',ctrl:"ESTATUSARTICULOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCESTATUSARTICULOID","Visible")',ctrl:"vCESTATUSARTICULOID",prop:"Visible"}]];this.EvtParms["LBLESTATUSARTICULODSCFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ESTATUSARTICULODSCFILTERCONTAINER","Class")',ctrl:"ESTATUSARTICULODSCFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ESTATUSARTICULODSCFILTERCONTAINER","Class")',ctrl:"ESTATUSARTICULODSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCESTATUSARTICULODSC","Visible")',ctrl:"vCESTATUSARTICULODSC",prop:"Visible"}]];this.EvtParms["LBLESTATUSARTICULODESCUSOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ESTATUSARTICULODESCUSOFILTERCONTAINER","Class")',ctrl:"ESTATUSARTICULODESCUSOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ESTATUSARTICULODESCUSOFILTERCONTAINER","Class")',ctrl:"ESTATUSARTICULODESCUSOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCESTATUSARTICULODESCUSO","Visible")',ctrl:"vCESTATUSARTICULODESCUSO",prop:"Visible"}]];this.EvtParms["LBLESTATUSARTICULOAPLICAMOVFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ESTATUSARTICULOAPLICAMOVFILTERCONTAINER","Class")',ctrl:"ESTATUSARTICULOAPLICAMOVFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ESTATUSARTICULOAPLICAMOVFILTERCONTAINER","Class")',ctrl:"ESTATUSARTICULOAPLICAMOVFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCESTATUSARTICULOAPLICAMOV","Visible")',ctrl:"vCESTATUSARTICULOAPLICAMOV",prop:"Visible"}]];this.EvtParms["LBLESTATUSARTICULOUSOTABLAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ESTATUSARTICULOUSOTABLAFILTERCONTAINER","Class")',ctrl:"ESTATUSARTICULOUSOTABLAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ESTATUSARTICULOUSOTABLAFILTERCONTAINER","Class")',ctrl:"ESTATUSARTICULOUSOTABLAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCESTATUSARTICULOUSOTABLA","Visible")',ctrl:"vCESTATUSARTICULOUSOTABLA",prop:"Visible"}]];this.EvtParms["LBLESTATUSARTICULOUSUARIOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ESTATUSARTICULOUSUARIOFILTERCONTAINER","Class")',ctrl:"ESTATUSARTICULOUSUARIOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ESTATUSARTICULOUSUARIOFILTERCONTAINER","Class")',ctrl:"ESTATUSARTICULOUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCESTATUSARTICULOUSUARIO","Visible")',ctrl:"vCESTATUSARTICULOUSUARIO",prop:"Visible"}]];this.EvtParms["LBLESTATUSARTICULOFECREGFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ESTATUSARTICULOFECREGFILTERCONTAINER","Class")',ctrl:"ESTATUSARTICULOFECREGFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ESTATUSARTICULOFECREGFILTERCONTAINER","Class")',ctrl:"ESTATUSARTICULOFECREGFILTERCONTAINER",prop:"Class"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A12estatusarticuloid",fld:"ESTATUSARTICULOID",pic:"ZZZZZZZZZZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV13pestatusarticuloid",fld:"vPESTATUSARTICULOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cestatusarticuloid",fld:"vCESTATUSARTICULOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7cestatusarticulodsc",fld:"vCESTATUSARTICULODSC",pic:"",nv:""},{av:"AV8cestatusarticulodescuso",fld:"vCESTATUSARTICULODESCUSO",pic:"",nv:""},{av:"AV9cestatusarticuloaplicamov",fld:"vCESTATUSARTICULOAPLICAMOV",pic:"ZZZZZZZZ9",nv:0},{av:"AV10cestatusarticulousotabla",fld:"vCESTATUSARTICULOUSOTABLA",pic:"",nv:""},{av:"AV11cestatusarticulousuario",fld:"vCESTATUSARTICULOUSUARIO",pic:"",nv:""},{av:"AV12cestatusarticulofecreg",fld:"vCESTATUSARTICULOFECREG",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cestatusarticuloid",fld:"vCESTATUSARTICULOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7cestatusarticulodsc",fld:"vCESTATUSARTICULODSC",pic:"",nv:""},{av:"AV8cestatusarticulodescuso",fld:"vCESTATUSARTICULODESCUSO",pic:"",nv:""},{av:"AV9cestatusarticuloaplicamov",fld:"vCESTATUSARTICULOAPLICAMOV",pic:"ZZZZZZZZ9",nv:0},{av:"AV10cestatusarticulousotabla",fld:"vCESTATUSARTICULOUSOTABLA",pic:"",nv:""},{av:"AV11cestatusarticulousuario",fld:"vCESTATUSARTICULOUSUARIO",pic:"",nv:""},{av:"AV12cestatusarticulofecreg",fld:"vCESTATUSARTICULOFECREG",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cestatusarticuloid",fld:"vCESTATUSARTICULOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7cestatusarticulodsc",fld:"vCESTATUSARTICULODSC",pic:"",nv:""},{av:"AV8cestatusarticulodescuso",fld:"vCESTATUSARTICULODESCUSO",pic:"",nv:""},{av:"AV9cestatusarticuloaplicamov",fld:"vCESTATUSARTICULOAPLICAMOV",pic:"ZZZZZZZZ9",nv:0},{av:"AV10cestatusarticulousotabla",fld:"vCESTATUSARTICULOUSOTABLA",pic:"",nv:""},{av:"AV11cestatusarticulousuario",fld:"vCESTATUSARTICULOUSUARIO",pic:"",nv:""},{av:"AV12cestatusarticulofecreg",fld:"vCESTATUSARTICULOFECREG",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cestatusarticuloid",fld:"vCESTATUSARTICULOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7cestatusarticulodsc",fld:"vCESTATUSARTICULODSC",pic:"",nv:""},{av:"AV8cestatusarticulodescuso",fld:"vCESTATUSARTICULODESCUSO",pic:"",nv:""},{av:"AV9cestatusarticuloaplicamov",fld:"vCESTATUSARTICULOAPLICAMOV",pic:"ZZZZZZZZ9",nv:0},{av:"AV10cestatusarticulousotabla",fld:"vCESTATUSARTICULOUSOTABLA",pic:"",nv:""},{av:"AV11cestatusarticulousuario",fld:"vCESTATUSARTICULOUSUARIO",pic:"",nv:""},{av:"AV12cestatusarticulofecreg",fld:"vCESTATUSARTICULOFECREG",pic:"99/99/9999 99:99:99",nv:""}],[]];this.setVCMap("AV13pestatusarticuloid","vPESTATUSARTICULOID",0,"int");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar(this.GXValidFnc[66]);t.addRefreshingVar(this.GXValidFnc[76]);this.InitStandaloneVars()});gx.createParentObj(gx0070)