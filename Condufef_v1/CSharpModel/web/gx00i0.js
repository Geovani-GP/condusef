/**@preserve  GeneXus C# 10_3_15-115824 on 2/15/2022 5:9:47.1
*/
gx.evt.autoSkip=!1;gx.define("gx00i0",!1,function(){var n,t;this.ServerClass="gx00i0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV13palmacenid=gx.fn.getIntegerValue("vPALMACENID",".")};this.e18241_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle"));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}])};this.e11241_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ALMACENIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ALMACENIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCALMACENID","Visible",!0)):(gx.fn.setCtrlProperty("ALMACENIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCALMACENID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ALMACENIDFILTERCONTAINER","Class")',ctrl:"ALMACENIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCALMACENID","Visible")',ctrl:"vCALMACENID",prop:"Visible"}])};this.e12241_client=function(){this.clearMessages();gx.fn.getCtrlProperty("EMPLEADOSIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("EMPLEADOSIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCEMPLEADOSID","Visible",!0)):(gx.fn.setCtrlProperty("EMPLEADOSIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCEMPLEADOSID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("EMPLEADOSIDFILTERCONTAINER","Class")',ctrl:"EMPLEADOSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPLEADOSID","Visible")',ctrl:"vCEMPLEADOSID",prop:"Visible"}])};this.e13241_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ALMACENDSCFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ALMACENDSCFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCALMACENDSC","Visible",!0)):(gx.fn.setCtrlProperty("ALMACENDSCFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCALMACENDSC","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ALMACENDSCFILTERCONTAINER","Class")',ctrl:"ALMACENDSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCALMACENDSC","Visible")',ctrl:"vCALMACENDSC",prop:"Visible"}])};this.e14241_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ALMACENDIRECCIONFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ALMACENDIRECCIONFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCALMACENDIRECCION","Visible",!0)):(gx.fn.setCtrlProperty("ALMACENDIRECCIONFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCALMACENDIRECCION","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ALMACENDIRECCIONFILTERCONTAINER","Class")',ctrl:"ALMACENDIRECCIONFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCALMACENDIRECCION","Visible")',ctrl:"vCALMACENDIRECCION",prop:"Visible"}])};this.e15241_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ALMACENCOLONIAFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ALMACENCOLONIAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCALMACENCOLONIA","Visible",!0)):(gx.fn.setCtrlProperty("ALMACENCOLONIAFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCALMACENCOLONIA","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ALMACENCOLONIAFILTERCONTAINER","Class")',ctrl:"ALMACENCOLONIAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCALMACENCOLONIA","Visible")',ctrl:"vCALMACENCOLONIA",prop:"Visible"}])};this.e16241_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ALMACENMUNICIPIOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ALMACENMUNICIPIOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCALMACENMUNICIPIO","Visible",!0)):(gx.fn.setCtrlProperty("ALMACENMUNICIPIOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCALMACENMUNICIPIO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ALMACENMUNICIPIOFILTERCONTAINER","Class")',ctrl:"ALMACENMUNICIPIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCALMACENMUNICIPIO","Visible")',ctrl:"vCALMACENMUNICIPIO",prop:"Visible"}])};this.e17241_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ALAMCENESTADOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ALAMCENESTADOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCALAMCENESTADO","Visible",!0)):(gx.fn.setCtrlProperty("ALAMCENESTADOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCALAMCENESTADO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ALAMCENESTADOFILTERCONTAINER","Class")',ctrl:"ALAMCENESTADOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCALAMCENESTADO","Visible")',ctrl:"vCALAMCENESTADO",prop:"Visible"}])};this.e21242_client=function(){this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e22241_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,82,83,85,86,87,88,89,90];this.GXLastCtrlId=90;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",84,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00i0",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",85,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(19,86,"ALMACENID","almacenid","","almacenid","int",0,"px",9,9,"right",null,[],19,"almacenid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(13,87,"EMPLEADOSID","empleadosid","","empleadosid","int",0,"px",9,9,"right",null,[],13,"empleadosid",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(143,88,"ALMACENDSC","almacendsc","","almacendsc","svchar",0,"px",100,80,"left",null,[],143,"almacendsc",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");this.setGrid(t);n[2]={fld:"",grid:0};n[3]={fld:"MAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"ADVANCEDCONTAINER",grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"ALMACENIDFILTERCONTAINER",grid:0};n[10]={fld:"",grid:0};n[11]={fld:"",grid:0};n[12]={fld:"LBLALMACENIDFILTER",format:1,grid:0};n[13]={fld:"",grid:0};n[14]={fld:"",grid:0};n[15]={fld:"",grid:0};n[16]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCALMACENID",gxz:"ZV6calmacenid",gxold:"OV6calmacenid",gxvar:"AV6calmacenid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6calmacenid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6calmacenid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCALMACENID",gx.O.AV6calmacenid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6calmacenid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCALMACENID",".")},nac:gx.falseFn};n[17]={fld:"",grid:0};n[18]={fld:"",grid:0};n[19]={fld:"EMPLEADOSIDFILTERCONTAINER",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={fld:"LBLEMPLEADOSIDFILTER",format:1,grid:0};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCEMPLEADOSID",gxz:"ZV7cempleadosid",gxold:"OV7cempleadosid",gxvar:"AV7cempleadosid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cempleadosid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7cempleadosid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCEMPLEADOSID",gx.O.AV7cempleadosid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cempleadosid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCEMPLEADOSID",".")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"ALMACENDSCFILTERCONTAINER",grid:0};n[30]={fld:"",grid:0};n[31]={fld:"",grid:0};n[32]={fld:"LBLALMACENDSCFILTER",format:1,grid:0};n[33]={fld:"",grid:0};n[34]={fld:"",grid:0};n[35]={fld:"",grid:0};n[36]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCALMACENDSC",gxz:"ZV8calmacendsc",gxold:"OV8calmacendsc",gxvar:"AV8calmacendsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8calmacendsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8calmacendsc=n)},v2c:function(){gx.fn.setControlValue("vCALMACENDSC",gx.O.AV8calmacendsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8calmacendsc=this.val())},val:function(){return gx.fn.getControlValue("vCALMACENDSC")},nac:gx.falseFn};n[37]={fld:"",grid:0};n[38]={fld:"",grid:0};n[39]={fld:"ALMACENDIRECCIONFILTERCONTAINER",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={fld:"LBLALMACENDIRECCIONFILTER",format:1,grid:0};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCALMACENDIRECCION",gxz:"ZV9calmacendireccion",gxold:"OV9calmacendireccion",gxvar:"AV9calmacendireccion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9calmacendireccion=n)},v2z:function(n){n!==undefined&&(gx.O.ZV9calmacendireccion=n)},v2c:function(){gx.fn.setControlValue("vCALMACENDIRECCION",gx.O.AV9calmacendireccion,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9calmacendireccion=this.val())},val:function(){return gx.fn.getControlValue("vCALMACENDIRECCION")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"ALMACENCOLONIAFILTERCONTAINER",grid:0};n[50]={fld:"",grid:0};n[51]={fld:"",grid:0};n[52]={fld:"LBLALMACENCOLONIAFILTER",format:1,grid:0};n[53]={fld:"",grid:0};n[54]={fld:"",grid:0};n[55]={fld:"",grid:0};n[56]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCALMACENCOLONIA",gxz:"ZV10calmacencolonia",gxold:"OV10calmacencolonia",gxvar:"AV10calmacencolonia",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10calmacencolonia=n)},v2z:function(n){n!==undefined&&(gx.O.ZV10calmacencolonia=n)},v2c:function(){gx.fn.setControlValue("vCALMACENCOLONIA",gx.O.AV10calmacencolonia,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10calmacencolonia=this.val())},val:function(){return gx.fn.getControlValue("vCALMACENCOLONIA")},nac:gx.falseFn};n[57]={fld:"",grid:0};n[58]={fld:"",grid:0};n[59]={fld:"ALMACENMUNICIPIOFILTERCONTAINER",grid:0};n[60]={fld:"",grid:0};n[61]={fld:"",grid:0};n[62]={fld:"LBLALMACENMUNICIPIOFILTER",format:1,grid:0};n[63]={fld:"",grid:0};n[64]={fld:"",grid:0};n[65]={fld:"",grid:0};n[66]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCALMACENMUNICIPIO",gxz:"ZV11calmacenmunicipio",gxold:"OV11calmacenmunicipio",gxvar:"AV11calmacenmunicipio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11calmacenmunicipio=n)},v2z:function(n){n!==undefined&&(gx.O.ZV11calmacenmunicipio=n)},v2c:function(){gx.fn.setControlValue("vCALMACENMUNICIPIO",gx.O.AV11calmacenmunicipio,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11calmacenmunicipio=this.val())},val:function(){return gx.fn.getControlValue("vCALMACENMUNICIPIO")},nac:gx.falseFn};n[67]={fld:"",grid:0};n[68]={fld:"",grid:0};n[69]={fld:"ALAMCENESTADOFILTERCONTAINER",grid:0};n[70]={fld:"",grid:0};n[71]={fld:"",grid:0};n[72]={fld:"LBLALAMCENESTADOFILTER",format:1,grid:0};n[73]={fld:"",grid:0};n[74]={fld:"",grid:0};n[75]={fld:"",grid:0};n[76]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCALAMCENESTADO",gxz:"ZV12calamcenestado",gxold:"OV12calamcenestado",gxvar:"AV12calamcenestado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV12calamcenestado=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12calamcenestado=n)},v2c:function(){gx.fn.setControlValue("vCALAMCENESTADO",gx.O.AV12calamcenestado,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV12calamcenestado=this.val())},val:function(){return gx.fn.getControlValue("vCALAMCENESTADO")},nac:gx.falseFn};n[77]={fld:"",grid:0};n[78]={fld:"GRIDTABLE",grid:0};n[79]={fld:"",grid:0};n[80]={fld:"",grid:0};n[82]={fld:"",grid:0};n[83]={fld:"",grid:0};n[85]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84),gx.O.AV5LinkSelection,gx.O.AV17Linkselection_GXI)},c2v:function(){gx.O.AV17Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(84))},gxvar_GXI:"AV17Linkselection_GXI",nac:gx.falseFn};n[86]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ALMACENID",gxz:"Z19almacenid",gxold:"O19almacenid",gxvar:"A19almacenid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A19almacenid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z19almacenid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ALMACENID",n||gx.fn.currentGridRowImpl(84),gx.O.A19almacenid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A19almacenid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ALMACENID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[87]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSID",gxz:"Z13empleadosid",gxold:"O13empleadosid",gxvar:"A13empleadosid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A13empleadosid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z13empleadosid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMPLEADOSID",n||gx.fn.currentGridRowImpl(84),gx.O.A13empleadosid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A13empleadosid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMPLEADOSID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[88]={lvl:2,type:"svchar",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ALMACENDSC",gxz:"Z143almacendsc",gxold:"O143almacendsc",gxvar:"A143almacendsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A143almacendsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z143almacendsc=n)},v2c:function(n){gx.fn.setGridControlValue("ALMACENDSC",n||gx.fn.currentGridRowImpl(84),gx.O.A143almacendsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A143almacendsc=this.val())},val:function(n){return gx.fn.getGridControlValue("ALMACENDSC",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[89]={fld:"",grid:0};n[90]={fld:"",grid:0};this.AV6calmacenid=0;this.ZV6calmacenid=0;this.OV6calmacenid=0;this.AV7cempleadosid=0;this.ZV7cempleadosid=0;this.OV7cempleadosid=0;this.AV8calmacendsc="";this.ZV8calmacendsc="";this.OV8calmacendsc="";this.AV9calmacendireccion="";this.ZV9calmacendireccion="";this.OV9calmacendireccion="";this.AV10calmacencolonia="";this.ZV10calmacencolonia="";this.OV10calmacencolonia="";this.AV11calmacenmunicipio="";this.ZV11calmacenmunicipio="";this.OV11calmacenmunicipio="";this.AV12calamcenestado="";this.ZV12calamcenestado="";this.OV12calamcenestado="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z19almacenid=0;this.O19almacenid=0;this.Z13empleadosid=0;this.O13empleadosid=0;this.Z143almacendsc="";this.O143almacendsc="";this.AV6calmacenid=0;this.AV7cempleadosid=0;this.AV8calmacendsc="";this.AV9calmacendireccion="";this.AV10calmacencolonia="";this.AV11calmacenmunicipio="";this.AV12calamcenestado="";this.AV13palmacenid=0;this.A147alamcenestado="";this.A146almacenmunicipio="";this.A145almacencolonia="";this.A144almacendireccion="";this.AV5LinkSelection="";this.A19almacenid=0;this.A13empleadosid=0;this.A143almacendsc="";this.Events={e21242_client:["ENTER",!0],e22241_client:["CANCEL",!0],e18241_client:["'TOGGLE'",!1],e11241_client:["LBLALMACENIDFILTER.CLICK",!1],e12241_client:["LBLEMPLEADOSIDFILTER.CLICK",!1],e13241_client:["LBLALMACENDSCFILTER.CLICK",!1],e14241_client:["LBLALMACENDIRECCIONFILTER.CLICK",!1],e15241_client:["LBLALMACENCOLONIAFILTER.CLICK",!1],e16241_client:["LBLALMACENMUNICIPIOFILTER.CLICK",!1],e17241_client:["LBLALAMCENESTADOFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6calmacenid",fld:"vCALMACENID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cempleadosid",fld:"vCEMPLEADOSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8calmacendsc",fld:"vCALMACENDSC",pic:"",nv:""},{av:"AV9calmacendireccion",fld:"vCALMACENDIRECCION",pic:"",nv:""},{av:"AV10calmacencolonia",fld:"vCALMACENCOLONIA",pic:"",nv:""},{av:"AV11calmacenmunicipio",fld:"vCALMACENMUNICIPIO",pic:"",nv:""},{av:"AV12calamcenestado",fld:"vCALAMCENESTADO",pic:"",nv:""}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLALMACENIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ALMACENIDFILTERCONTAINER","Class")',ctrl:"ALMACENIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ALMACENIDFILTERCONTAINER","Class")',ctrl:"ALMACENIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCALMACENID","Visible")',ctrl:"vCALMACENID",prop:"Visible"}]];this.EvtParms["LBLEMPLEADOSIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("EMPLEADOSIDFILTERCONTAINER","Class")',ctrl:"EMPLEADOSIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("EMPLEADOSIDFILTERCONTAINER","Class")',ctrl:"EMPLEADOSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPLEADOSID","Visible")',ctrl:"vCEMPLEADOSID",prop:"Visible"}]];this.EvtParms["LBLALMACENDSCFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ALMACENDSCFILTERCONTAINER","Class")',ctrl:"ALMACENDSCFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ALMACENDSCFILTERCONTAINER","Class")',ctrl:"ALMACENDSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCALMACENDSC","Visible")',ctrl:"vCALMACENDSC",prop:"Visible"}]];this.EvtParms["LBLALMACENDIRECCIONFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ALMACENDIRECCIONFILTERCONTAINER","Class")',ctrl:"ALMACENDIRECCIONFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ALMACENDIRECCIONFILTERCONTAINER","Class")',ctrl:"ALMACENDIRECCIONFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCALMACENDIRECCION","Visible")',ctrl:"vCALMACENDIRECCION",prop:"Visible"}]];this.EvtParms["LBLALMACENCOLONIAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ALMACENCOLONIAFILTERCONTAINER","Class")',ctrl:"ALMACENCOLONIAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ALMACENCOLONIAFILTERCONTAINER","Class")',ctrl:"ALMACENCOLONIAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCALMACENCOLONIA","Visible")',ctrl:"vCALMACENCOLONIA",prop:"Visible"}]];this.EvtParms["LBLALMACENMUNICIPIOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ALMACENMUNICIPIOFILTERCONTAINER","Class")',ctrl:"ALMACENMUNICIPIOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ALMACENMUNICIPIOFILTERCONTAINER","Class")',ctrl:"ALMACENMUNICIPIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCALMACENMUNICIPIO","Visible")',ctrl:"vCALMACENMUNICIPIO",prop:"Visible"}]];this.EvtParms["LBLALAMCENESTADOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ALAMCENESTADOFILTERCONTAINER","Class")',ctrl:"ALAMCENESTADOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ALAMCENESTADOFILTERCONTAINER","Class")',ctrl:"ALAMCENESTADOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCALAMCENESTADO","Visible")',ctrl:"vCALAMCENESTADO",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A19almacenid",fld:"ALMACENID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV13palmacenid",fld:"vPALMACENID",pic:"ZZZZZZZZ9",nv:0}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6calmacenid",fld:"vCALMACENID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cempleadosid",fld:"vCEMPLEADOSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8calmacendsc",fld:"vCALMACENDSC",pic:"",nv:""},{av:"AV9calmacendireccion",fld:"vCALMACENDIRECCION",pic:"",nv:""},{av:"AV10calmacencolonia",fld:"vCALMACENCOLONIA",pic:"",nv:""},{av:"AV11calmacenmunicipio",fld:"vCALMACENMUNICIPIO",pic:"",nv:""},{av:"AV12calamcenestado",fld:"vCALAMCENESTADO",pic:"",nv:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6calmacenid",fld:"vCALMACENID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cempleadosid",fld:"vCEMPLEADOSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8calmacendsc",fld:"vCALMACENDSC",pic:"",nv:""},{av:"AV9calmacendireccion",fld:"vCALMACENDIRECCION",pic:"",nv:""},{av:"AV10calmacencolonia",fld:"vCALMACENCOLONIA",pic:"",nv:""},{av:"AV11calmacenmunicipio",fld:"vCALMACENMUNICIPIO",pic:"",nv:""},{av:"AV12calamcenestado",fld:"vCALAMCENESTADO",pic:"",nv:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6calmacenid",fld:"vCALMACENID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cempleadosid",fld:"vCEMPLEADOSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8calmacendsc",fld:"vCALMACENDSC",pic:"",nv:""},{av:"AV9calmacendireccion",fld:"vCALMACENDIRECCION",pic:"",nv:""},{av:"AV10calmacencolonia",fld:"vCALMACENCOLONIA",pic:"",nv:""},{av:"AV11calmacenmunicipio",fld:"vCALMACENMUNICIPIO",pic:"",nv:""},{av:"AV12calamcenestado",fld:"vCALAMCENESTADO",pic:"",nv:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6calmacenid",fld:"vCALMACENID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cempleadosid",fld:"vCEMPLEADOSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8calmacendsc",fld:"vCALMACENDSC",pic:"",nv:""},{av:"AV9calmacendireccion",fld:"vCALMACENDIRECCION",pic:"",nv:""},{av:"AV10calmacencolonia",fld:"vCALMACENCOLONIA",pic:"",nv:""},{av:"AV11calmacenmunicipio",fld:"vCALMACENMUNICIPIO",pic:"",nv:""},{av:"AV12calamcenestado",fld:"vCALAMCENESTADO",pic:"",nv:""}],[]];this.setVCMap("AV13palmacenid","vPALMACENID",0,"int");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar(this.GXValidFnc[66]);t.addRefreshingVar(this.GXValidFnc[76]);this.InitStandaloneVars()});gx.createParentObj(gx00i0)