/**@preserve  GeneXus C# 10_3_15-115824 on 2/2/2022 13:43:18.13
*/
gx.evt.autoSkip=!1;gx.define("gx00a0",!1,function(){var n,t;this.ServerClass="gx00a0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV13pproveedoresid=gx.fn.getIntegerValue("vPPROVEEDORESID",".")};this.e18201_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle"));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}])};this.e11201_client=function(){this.clearMessages();gx.fn.getCtrlProperty("PROVEEDORESIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PROVEEDORESIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPROVEEDORESID","Visible",!0)):(gx.fn.setCtrlProperty("PROVEEDORESIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPROVEEDORESID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PROVEEDORESIDFILTERCONTAINER","Class")',ctrl:"PROVEEDORESIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROVEEDORESID","Visible")',ctrl:"vCPROVEEDORESID",prop:"Visible"}])};this.e12201_client=function(){this.clearMessages();gx.fn.getCtrlProperty("PROVEEDORESNOMBREFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PROVEEDORESNOMBREFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPROVEEDORESNOMBRE","Visible",!0)):(gx.fn.setCtrlProperty("PROVEEDORESNOMBREFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPROVEEDORESNOMBRE","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PROVEEDORESNOMBREFILTERCONTAINER","Class")',ctrl:"PROVEEDORESNOMBREFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROVEEDORESNOMBRE","Visible")',ctrl:"vCPROVEEDORESNOMBRE",prop:"Visible"}])};this.e13201_client=function(){this.clearMessages();gx.fn.getCtrlProperty("PROVEEDORESDIRECCIONFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PROVEEDORESDIRECCIONFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPROVEEDORESDIRECCION","Visible",!0)):(gx.fn.setCtrlProperty("PROVEEDORESDIRECCIONFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPROVEEDORESDIRECCION","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PROVEEDORESDIRECCIONFILTERCONTAINER","Class")',ctrl:"PROVEEDORESDIRECCIONFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROVEEDORESDIRECCION","Visible")',ctrl:"vCPROVEEDORESDIRECCION",prop:"Visible"}])};this.e14201_client=function(){this.clearMessages();gx.fn.getCtrlProperty("PROVEEDORESCOLONIAFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PROVEEDORESCOLONIAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPROVEEDORESCOLONIA","Visible",!0)):(gx.fn.setCtrlProperty("PROVEEDORESCOLONIAFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPROVEEDORESCOLONIA","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PROVEEDORESCOLONIAFILTERCONTAINER","Class")',ctrl:"PROVEEDORESCOLONIAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROVEEDORESCOLONIA","Visible")',ctrl:"vCPROVEEDORESCOLONIA",prop:"Visible"}])};this.e15201_client=function(){this.clearMessages();gx.fn.getCtrlProperty("PROVEEDORESCODIGOPOSTALFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PROVEEDORESCODIGOPOSTALFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPROVEEDORESCODIGOPOSTAL","Visible",!0)):(gx.fn.setCtrlProperty("PROVEEDORESCODIGOPOSTALFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPROVEEDORESCODIGOPOSTAL","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PROVEEDORESCODIGOPOSTALFILTERCONTAINER","Class")',ctrl:"PROVEEDORESCODIGOPOSTALFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROVEEDORESCODIGOPOSTAL","Visible")',ctrl:"vCPROVEEDORESCODIGOPOSTAL",prop:"Visible"}])};this.e16201_client=function(){this.clearMessages();gx.fn.getCtrlProperty("PROVEEDORESMUNICIPIOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PROVEEDORESMUNICIPIOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPROVEEDORESMUNICIPIO","Visible",!0)):(gx.fn.setCtrlProperty("PROVEEDORESMUNICIPIOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPROVEEDORESMUNICIPIO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PROVEEDORESMUNICIPIOFILTERCONTAINER","Class")',ctrl:"PROVEEDORESMUNICIPIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROVEEDORESMUNICIPIO","Visible")',ctrl:"vCPROVEEDORESMUNICIPIO",prop:"Visible"}])};this.e17201_client=function(){this.clearMessages();gx.fn.getCtrlProperty("PROVEEDORESTADOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PROVEEDORESTADOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPROVEEDORESTADO","Visible",!0)):(gx.fn.setCtrlProperty("PROVEEDORESTADOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPROVEEDORESTADO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PROVEEDORESTADOFILTERCONTAINER","Class")',ctrl:"PROVEEDORESTADOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROVEEDORESTADO","Visible")',ctrl:"vCPROVEEDORESTADO",prop:"Visible"}])};this.e21202_client=function(){this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e22201_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,82,83,85,86,87,88,89,90];this.GXLastCtrlId=90;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",84,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00a0",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",85,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(2,86,"PROVEEDORESID","proveedoresid","","proveedoresid","int",0,"px",9,9,"right",null,[],2,"proveedoresid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(126,87,"PROVEEDORESNOMBRE","proveedoresnombre","","proveedoresnombre","svchar",0,"px",80,80,"left",null,[],126,"proveedoresnombre",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(128,88,"PROVEEDORESCOLONIA","proveedorescolonia","","proveedorescolonia","svchar",0,"px",25,25,"left",null,[],128,"proveedorescolonia",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.setGrid(t);n[2]={fld:"",grid:0};n[3]={fld:"MAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"ADVANCEDCONTAINER",grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"PROVEEDORESIDFILTERCONTAINER",grid:0};n[10]={fld:"",grid:0};n[11]={fld:"",grid:0};n[12]={fld:"LBLPROVEEDORESIDFILTER",format:1,grid:0};n[13]={fld:"",grid:0};n[14]={fld:"",grid:0};n[15]={fld:"",grid:0};n[16]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPROVEEDORESID",gxz:"ZV6cproveedoresid",gxold:"OV6cproveedoresid",gxvar:"AV6cproveedoresid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cproveedoresid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cproveedoresid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCPROVEEDORESID",gx.O.AV6cproveedoresid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cproveedoresid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCPROVEEDORESID",".")},nac:gx.falseFn};n[17]={fld:"",grid:0};n[18]={fld:"",grid:0};n[19]={fld:"PROVEEDORESNOMBREFILTERCONTAINER",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={fld:"LBLPROVEEDORESNOMBREFILTER",format:1,grid:0};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:80,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPROVEEDORESNOMBRE",gxz:"ZV7cproveedoresnombre",gxold:"OV7cproveedoresnombre",gxvar:"AV7cproveedoresnombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cproveedoresnombre=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cproveedoresnombre=n)},v2c:function(){gx.fn.setControlValue("vCPROVEEDORESNOMBRE",gx.O.AV7cproveedoresnombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cproveedoresnombre=this.val())},val:function(){return gx.fn.getControlValue("vCPROVEEDORESNOMBRE")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"PROVEEDORESDIRECCIONFILTERCONTAINER",grid:0};n[30]={fld:"",grid:0};n[31]={fld:"",grid:0};n[32]={fld:"LBLPROVEEDORESDIRECCIONFILTER",format:1,grid:0};n[33]={fld:"",grid:0};n[34]={fld:"",grid:0};n[35]={fld:"",grid:0};n[36]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPROVEEDORESDIRECCION",gxz:"ZV8cproveedoresdireccion",gxold:"OV8cproveedoresdireccion",gxvar:"AV8cproveedoresdireccion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cproveedoresdireccion=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cproveedoresdireccion=n)},v2c:function(){gx.fn.setControlValue("vCPROVEEDORESDIRECCION",gx.O.AV8cproveedoresdireccion,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cproveedoresdireccion=this.val())},val:function(){return gx.fn.getControlValue("vCPROVEEDORESDIRECCION")},nac:gx.falseFn};n[37]={fld:"",grid:0};n[38]={fld:"",grid:0};n[39]={fld:"PROVEEDORESCOLONIAFILTERCONTAINER",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={fld:"LBLPROVEEDORESCOLONIAFILTER",format:1,grid:0};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"svchar",len:25,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPROVEEDORESCOLONIA",gxz:"ZV9cproveedorescolonia",gxold:"OV9cproveedorescolonia",gxvar:"AV9cproveedorescolonia",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9cproveedorescolonia=n)},v2z:function(n){n!==undefined&&(gx.O.ZV9cproveedorescolonia=n)},v2c:function(){gx.fn.setControlValue("vCPROVEEDORESCOLONIA",gx.O.AV9cproveedorescolonia,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9cproveedorescolonia=this.val())},val:function(){return gx.fn.getControlValue("vCPROVEEDORESCOLONIA")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"PROVEEDORESCODIGOPOSTALFILTERCONTAINER",grid:0};n[50]={fld:"",grid:0};n[51]={fld:"",grid:0};n[52]={fld:"LBLPROVEEDORESCODIGOPOSTALFILTER",format:1,grid:0};n[53]={fld:"",grid:0};n[54]={fld:"",grid:0};n[55]={fld:"",grid:0};n[56]={lvl:0,type:"svchar",len:5,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPROVEEDORESCODIGOPOSTAL",gxz:"ZV10cproveedorescodigopostal",gxold:"OV10cproveedorescodigopostal",gxvar:"AV10cproveedorescodigopostal",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10cproveedorescodigopostal=n)},v2z:function(n){n!==undefined&&(gx.O.ZV10cproveedorescodigopostal=n)},v2c:function(){gx.fn.setControlValue("vCPROVEEDORESCODIGOPOSTAL",gx.O.AV10cproveedorescodigopostal,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10cproveedorescodigopostal=this.val())},val:function(){return gx.fn.getControlValue("vCPROVEEDORESCODIGOPOSTAL")},nac:gx.falseFn};n[57]={fld:"",grid:0};n[58]={fld:"",grid:0};n[59]={fld:"PROVEEDORESMUNICIPIOFILTERCONTAINER",grid:0};n[60]={fld:"",grid:0};n[61]={fld:"",grid:0};n[62]={fld:"LBLPROVEEDORESMUNICIPIOFILTER",format:1,grid:0};n[63]={fld:"",grid:0};n[64]={fld:"",grid:0};n[65]={fld:"",grid:0};n[66]={lvl:0,type:"svchar",len:25,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPROVEEDORESMUNICIPIO",gxz:"ZV11cproveedoresmunicipio",gxold:"OV11cproveedoresmunicipio",gxvar:"AV11cproveedoresmunicipio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11cproveedoresmunicipio=n)},v2z:function(n){n!==undefined&&(gx.O.ZV11cproveedoresmunicipio=n)},v2c:function(){gx.fn.setControlValue("vCPROVEEDORESMUNICIPIO",gx.O.AV11cproveedoresmunicipio,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11cproveedoresmunicipio=this.val())},val:function(){return gx.fn.getControlValue("vCPROVEEDORESMUNICIPIO")},nac:gx.falseFn};n[67]={fld:"",grid:0};n[68]={fld:"",grid:0};n[69]={fld:"PROVEEDORESTADOFILTERCONTAINER",grid:0};n[70]={fld:"",grid:0};n[71]={fld:"",grid:0};n[72]={fld:"LBLPROVEEDORESTADOFILTER",format:1,grid:0};n[73]={fld:"",grid:0};n[74]={fld:"",grid:0};n[75]={fld:"",grid:0};n[76]={lvl:0,type:"svchar",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPROVEEDORESTADO",gxz:"ZV12cproveedorestado",gxold:"OV12cproveedorestado",gxvar:"AV12cproveedorestado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV12cproveedorestado=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12cproveedorestado=n)},v2c:function(){gx.fn.setControlValue("vCPROVEEDORESTADO",gx.O.AV12cproveedorestado,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV12cproveedorestado=this.val())},val:function(){return gx.fn.getControlValue("vCPROVEEDORESTADO")},nac:gx.falseFn};n[77]={fld:"",grid:0};n[78]={fld:"GRIDTABLE",grid:0};n[79]={fld:"",grid:0};n[80]={fld:"",grid:0};n[82]={fld:"",grid:0};n[83]={fld:"",grid:0};n[85]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84),gx.O.AV5LinkSelection,gx.O.AV17Linkselection_GXI)},c2v:function(){gx.O.AV17Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(84))},gxvar_GXI:"AV17Linkselection_GXI",nac:gx.falseFn};n[86]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESID",gxz:"Z2proveedoresid",gxold:"O2proveedoresid",gxvar:"A2proveedoresid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A2proveedoresid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z2proveedoresid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("PROVEEDORESID",n||gx.fn.currentGridRowImpl(84),gx.O.A2proveedoresid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A2proveedoresid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PROVEEDORESID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[87]={lvl:2,type:"svchar",len:80,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESNOMBRE",gxz:"Z126proveedoresnombre",gxold:"O126proveedoresnombre",gxvar:"A126proveedoresnombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A126proveedoresnombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z126proveedoresnombre=n)},v2c:function(n){gx.fn.setGridControlValue("PROVEEDORESNOMBRE",n||gx.fn.currentGridRowImpl(84),gx.O.A126proveedoresnombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A126proveedoresnombre=this.val())},val:function(n){return gx.fn.getGridControlValue("PROVEEDORESNOMBRE",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[88]={lvl:2,type:"svchar",len:25,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESCOLONIA",gxz:"Z128proveedorescolonia",gxold:"O128proveedorescolonia",gxvar:"A128proveedorescolonia",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A128proveedorescolonia=n)},v2z:function(n){n!==undefined&&(gx.O.Z128proveedorescolonia=n)},v2c:function(n){gx.fn.setGridControlValue("PROVEEDORESCOLONIA",n||gx.fn.currentGridRowImpl(84),gx.O.A128proveedorescolonia,0)},c2v:function(){this.val()!==undefined&&(gx.O.A128proveedorescolonia=this.val())},val:function(n){return gx.fn.getGridControlValue("PROVEEDORESCOLONIA",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[89]={fld:"",grid:0};n[90]={fld:"",grid:0};this.AV6cproveedoresid=0;this.ZV6cproveedoresid=0;this.OV6cproveedoresid=0;this.AV7cproveedoresnombre="";this.ZV7cproveedoresnombre="";this.OV7cproveedoresnombre="";this.AV8cproveedoresdireccion="";this.ZV8cproveedoresdireccion="";this.OV8cproveedoresdireccion="";this.AV9cproveedorescolonia="";this.ZV9cproveedorescolonia="";this.OV9cproveedorescolonia="";this.AV10cproveedorescodigopostal="";this.ZV10cproveedorescodigopostal="";this.OV10cproveedorescodigopostal="";this.AV11cproveedoresmunicipio="";this.ZV11cproveedoresmunicipio="";this.OV11cproveedoresmunicipio="";this.AV12cproveedorestado="";this.ZV12cproveedorestado="";this.OV12cproveedorestado="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z2proveedoresid=0;this.O2proveedoresid=0;this.Z126proveedoresnombre="";this.O126proveedoresnombre="";this.Z128proveedorescolonia="";this.O128proveedorescolonia="";this.AV6cproveedoresid=0;this.AV7cproveedoresnombre="";this.AV8cproveedoresdireccion="";this.AV9cproveedorescolonia="";this.AV10cproveedorescodigopostal="";this.AV11cproveedoresmunicipio="";this.AV12cproveedorestado="";this.AV13pproveedoresid=0;this.A131proveedorestado="";this.A130proveedoresmunicipio="";this.A129proveedorescodigopostal="";this.A127proveedoresdireccion="";this.AV5LinkSelection="";this.A2proveedoresid=0;this.A126proveedoresnombre="";this.A128proveedorescolonia="";this.Events={e21202_client:["ENTER",!0],e22201_client:["CANCEL",!0],e18201_client:["'TOGGLE'",!1],e11201_client:["LBLPROVEEDORESIDFILTER.CLICK",!1],e12201_client:["LBLPROVEEDORESNOMBREFILTER.CLICK",!1],e13201_client:["LBLPROVEEDORESDIRECCIONFILTER.CLICK",!1],e14201_client:["LBLPROVEEDORESCOLONIAFILTER.CLICK",!1],e15201_client:["LBLPROVEEDORESCODIGOPOSTALFILTER.CLICK",!1],e16201_client:["LBLPROVEEDORESMUNICIPIOFILTER.CLICK",!1],e17201_client:["LBLPROVEEDORESTADOFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cproveedoresid",fld:"vCPROVEEDORESID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cproveedoresnombre",fld:"vCPROVEEDORESNOMBRE",pic:"",nv:""},{av:"AV8cproveedoresdireccion",fld:"vCPROVEEDORESDIRECCION",pic:"",nv:""},{av:"AV9cproveedorescolonia",fld:"vCPROVEEDORESCOLONIA",pic:"",nv:""},{av:"AV10cproveedorescodigopostal",fld:"vCPROVEEDORESCODIGOPOSTAL",pic:"",nv:""},{av:"AV11cproveedoresmunicipio",fld:"vCPROVEEDORESMUNICIPIO",pic:"",nv:""},{av:"AV12cproveedorestado",fld:"vCPROVEEDORESTADO",pic:"",nv:""}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLPROVEEDORESIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PROVEEDORESIDFILTERCONTAINER","Class")',ctrl:"PROVEEDORESIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PROVEEDORESIDFILTERCONTAINER","Class")',ctrl:"PROVEEDORESIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROVEEDORESID","Visible")',ctrl:"vCPROVEEDORESID",prop:"Visible"}]];this.EvtParms["LBLPROVEEDORESNOMBREFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PROVEEDORESNOMBREFILTERCONTAINER","Class")',ctrl:"PROVEEDORESNOMBREFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PROVEEDORESNOMBREFILTERCONTAINER","Class")',ctrl:"PROVEEDORESNOMBREFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROVEEDORESNOMBRE","Visible")',ctrl:"vCPROVEEDORESNOMBRE",prop:"Visible"}]];this.EvtParms["LBLPROVEEDORESDIRECCIONFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PROVEEDORESDIRECCIONFILTERCONTAINER","Class")',ctrl:"PROVEEDORESDIRECCIONFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PROVEEDORESDIRECCIONFILTERCONTAINER","Class")',ctrl:"PROVEEDORESDIRECCIONFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROVEEDORESDIRECCION","Visible")',ctrl:"vCPROVEEDORESDIRECCION",prop:"Visible"}]];this.EvtParms["LBLPROVEEDORESCOLONIAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PROVEEDORESCOLONIAFILTERCONTAINER","Class")',ctrl:"PROVEEDORESCOLONIAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PROVEEDORESCOLONIAFILTERCONTAINER","Class")',ctrl:"PROVEEDORESCOLONIAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROVEEDORESCOLONIA","Visible")',ctrl:"vCPROVEEDORESCOLONIA",prop:"Visible"}]];this.EvtParms["LBLPROVEEDORESCODIGOPOSTALFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PROVEEDORESCODIGOPOSTALFILTERCONTAINER","Class")',ctrl:"PROVEEDORESCODIGOPOSTALFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PROVEEDORESCODIGOPOSTALFILTERCONTAINER","Class")',ctrl:"PROVEEDORESCODIGOPOSTALFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROVEEDORESCODIGOPOSTAL","Visible")',ctrl:"vCPROVEEDORESCODIGOPOSTAL",prop:"Visible"}]];this.EvtParms["LBLPROVEEDORESMUNICIPIOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PROVEEDORESMUNICIPIOFILTERCONTAINER","Class")',ctrl:"PROVEEDORESMUNICIPIOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PROVEEDORESMUNICIPIOFILTERCONTAINER","Class")',ctrl:"PROVEEDORESMUNICIPIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROVEEDORESMUNICIPIO","Visible")',ctrl:"vCPROVEEDORESMUNICIPIO",prop:"Visible"}]];this.EvtParms["LBLPROVEEDORESTADOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PROVEEDORESTADOFILTERCONTAINER","Class")',ctrl:"PROVEEDORESTADOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PROVEEDORESTADOFILTERCONTAINER","Class")',ctrl:"PROVEEDORESTADOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROVEEDORESTADO","Visible")',ctrl:"vCPROVEEDORESTADO",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A2proveedoresid",fld:"PROVEEDORESID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV13pproveedoresid",fld:"vPPROVEEDORESID",pic:"ZZZZZZZZ9",nv:0}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cproveedoresid",fld:"vCPROVEEDORESID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cproveedoresnombre",fld:"vCPROVEEDORESNOMBRE",pic:"",nv:""},{av:"AV8cproveedoresdireccion",fld:"vCPROVEEDORESDIRECCION",pic:"",nv:""},{av:"AV9cproveedorescolonia",fld:"vCPROVEEDORESCOLONIA",pic:"",nv:""},{av:"AV10cproveedorescodigopostal",fld:"vCPROVEEDORESCODIGOPOSTAL",pic:"",nv:""},{av:"AV11cproveedoresmunicipio",fld:"vCPROVEEDORESMUNICIPIO",pic:"",nv:""},{av:"AV12cproveedorestado",fld:"vCPROVEEDORESTADO",pic:"",nv:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cproveedoresid",fld:"vCPROVEEDORESID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cproveedoresnombre",fld:"vCPROVEEDORESNOMBRE",pic:"",nv:""},{av:"AV8cproveedoresdireccion",fld:"vCPROVEEDORESDIRECCION",pic:"",nv:""},{av:"AV9cproveedorescolonia",fld:"vCPROVEEDORESCOLONIA",pic:"",nv:""},{av:"AV10cproveedorescodigopostal",fld:"vCPROVEEDORESCODIGOPOSTAL",pic:"",nv:""},{av:"AV11cproveedoresmunicipio",fld:"vCPROVEEDORESMUNICIPIO",pic:"",nv:""},{av:"AV12cproveedorestado",fld:"vCPROVEEDORESTADO",pic:"",nv:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cproveedoresid",fld:"vCPROVEEDORESID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cproveedoresnombre",fld:"vCPROVEEDORESNOMBRE",pic:"",nv:""},{av:"AV8cproveedoresdireccion",fld:"vCPROVEEDORESDIRECCION",pic:"",nv:""},{av:"AV9cproveedorescolonia",fld:"vCPROVEEDORESCOLONIA",pic:"",nv:""},{av:"AV10cproveedorescodigopostal",fld:"vCPROVEEDORESCODIGOPOSTAL",pic:"",nv:""},{av:"AV11cproveedoresmunicipio",fld:"vCPROVEEDORESMUNICIPIO",pic:"",nv:""},{av:"AV12cproveedorestado",fld:"vCPROVEEDORESTADO",pic:"",nv:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cproveedoresid",fld:"vCPROVEEDORESID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cproveedoresnombre",fld:"vCPROVEEDORESNOMBRE",pic:"",nv:""},{av:"AV8cproveedoresdireccion",fld:"vCPROVEEDORESDIRECCION",pic:"",nv:""},{av:"AV9cproveedorescolonia",fld:"vCPROVEEDORESCOLONIA",pic:"",nv:""},{av:"AV10cproveedorescodigopostal",fld:"vCPROVEEDORESCODIGOPOSTAL",pic:"",nv:""},{av:"AV11cproveedoresmunicipio",fld:"vCPROVEEDORESMUNICIPIO",pic:"",nv:""},{av:"AV12cproveedorestado",fld:"vCPROVEEDORESTADO",pic:"",nv:""}],[]];this.setVCMap("AV13pproveedoresid","vPPROVEEDORESID",0,"int");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar(this.GXValidFnc[66]);t.addRefreshingVar(this.GXValidFnc[76]);this.InitStandaloneVars()});gx.createParentObj(gx00a0)