/**@preserve  GeneXus C# 10_3_15-115824 on 1/28/2022 1:41:14.56
*/
gx.evt.autoSkip=!1;gx.define("gx0060",!1,function(){var n,t;this.ServerClass="gx0060";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV13pempleadosid=gx.fn.getIntegerValue("vPEMPLEADOSID",".")};this.e181v1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle"));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}])};this.e111v1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("EMPLEADOSIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("EMPLEADOSIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCEMPLEADOSID","Visible",!0)):(gx.fn.setCtrlProperty("EMPLEADOSIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCEMPLEADOSID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("EMPLEADOSIDFILTERCONTAINER","Class")',ctrl:"EMPLEADOSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPLEADOSID","Visible")',ctrl:"vCEMPLEADOSID",prop:"Visible"}])};this.e121v1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("EMPLEADOSAREAIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("EMPLEADOSAREAIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCEMPLEADOSAREAID","Visible",!0)):(gx.fn.setCtrlProperty("EMPLEADOSAREAIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCEMPLEADOSAREAID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("EMPLEADOSAREAIDFILTERCONTAINER","Class")',ctrl:"EMPLEADOSAREAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPLEADOSAREAID","Visible")',ctrl:"vCEMPLEADOSAREAID",prop:"Visible"}])};this.e131v1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("EMPLEADOSNOMEMPLEFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("EMPLEADOSNOMEMPLEFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCEMPLEADOSNOMEMPLE","Visible",!0)):(gx.fn.setCtrlProperty("EMPLEADOSNOMEMPLEFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCEMPLEADOSNOMEMPLE","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("EMPLEADOSNOMEMPLEFILTERCONTAINER","Class")',ctrl:"EMPLEADOSNOMEMPLEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPLEADOSNOMEMPLE","Visible")',ctrl:"vCEMPLEADOSNOMEMPLE",prop:"Visible"}])};this.e141v1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("EMPLEADOSAPPATERNOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("EMPLEADOSAPPATERNOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCEMPLEADOSAPPATERNO","Visible",!0)):(gx.fn.setCtrlProperty("EMPLEADOSAPPATERNOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCEMPLEADOSAPPATERNO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("EMPLEADOSAPPATERNOFILTERCONTAINER","Class")',ctrl:"EMPLEADOSAPPATERNOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPLEADOSAPPATERNO","Visible")',ctrl:"vCEMPLEADOSAPPATERNO",prop:"Visible"}])};this.e151v1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("EMPLEADOSAPMATERNOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("EMPLEADOSAPMATERNOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCEMPLEADOSAPMATERNO","Visible",!0)):(gx.fn.setCtrlProperty("EMPLEADOSAPMATERNOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCEMPLEADOSAPMATERNO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("EMPLEADOSAPMATERNOFILTERCONTAINER","Class")',ctrl:"EMPLEADOSAPMATERNOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPLEADOSAPMATERNO","Visible")',ctrl:"vCEMPLEADOSAPMATERNO",prop:"Visible"}])};this.e161v1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("EMPLEADOSSTATUSFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("EMPLEADOSSTATUSFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCEMPLEADOSSTATUS","Visible",!0)):(gx.fn.setCtrlProperty("EMPLEADOSSTATUSFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCEMPLEADOSSTATUS","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("EMPLEADOSSTATUSFILTERCONTAINER","Class")',ctrl:"EMPLEADOSSTATUSFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPLEADOSSTATUS","Visible")',ctrl:"vCEMPLEADOSSTATUS",prop:"Visible"}])};this.e171v1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("EMPLEADOSUSUARIOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("EMPLEADOSUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCEMPLEADOSUSUARIO","Visible",!0)):(gx.fn.setCtrlProperty("EMPLEADOSUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCEMPLEADOSUSUARIO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("EMPLEADOSUSUARIOFILTERCONTAINER","Class")',ctrl:"EMPLEADOSUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPLEADOSUSUARIO","Visible")',ctrl:"vCEMPLEADOSUSUARIO",prop:"Visible"}])};this.e211v2_client=function(){this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e221v1_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,82,83,85,86,87,88,89,90,91,92];this.GXLastCtrlId=92;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",84,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0060",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",85,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(13,86,"EMPLEADOSID","empleadosid","","empleadosid","int",0,"px",9,9,"right",null,[],13,"empleadosid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(98,87,"EMPLEADOSAREAID","areaid","","empleadosareaid","svchar",0,"px",3,3,"left",null,[],98,"empleadosareaid",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(99,88,"EMPLEADOSNOMEMPLE","empleadosnomemple","","empleadosnomemple","svchar",0,"px",30,30,"left",null,[],99,"empleadosnomemple",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(100,89,"EMPLEADOSAPPATERNO","empleadosappaterno","","empleadosappaterno","svchar",0,"px",30,30,"left",null,[],100,"empleadosappaterno",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(101,90,"EMPLEADOSAPMATERNO","empleadosapmaterno","","empleadosapmaterno","svchar",0,"px",30,30,"left",null,[],101,"empleadosapmaterno",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.setGrid(t);n[2]={fld:"",grid:0};n[3]={fld:"MAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"ADVANCEDCONTAINER",grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"EMPLEADOSIDFILTERCONTAINER",grid:0};n[10]={fld:"",grid:0};n[11]={fld:"",grid:0};n[12]={fld:"LBLEMPLEADOSIDFILTER",format:1,grid:0};n[13]={fld:"",grid:0};n[14]={fld:"",grid:0};n[15]={fld:"",grid:0};n[16]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCEMPLEADOSID",gxz:"ZV6cempleadosid",gxold:"OV6cempleadosid",gxvar:"AV6cempleadosid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cempleadosid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cempleadosid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCEMPLEADOSID",gx.O.AV6cempleadosid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cempleadosid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCEMPLEADOSID",".")},nac:gx.falseFn};n[17]={fld:"",grid:0};n[18]={fld:"",grid:0};n[19]={fld:"EMPLEADOSAREAIDFILTERCONTAINER",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={fld:"LBLEMPLEADOSAREAIDFILTER",format:1,grid:0};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:3,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCEMPLEADOSAREAID",gxz:"ZV7cempleadosareaid",gxold:"OV7cempleadosareaid",gxvar:"AV7cempleadosareaid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cempleadosareaid=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cempleadosareaid=n)},v2c:function(){gx.fn.setControlValue("vCEMPLEADOSAREAID",gx.O.AV7cempleadosareaid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cempleadosareaid=this.val())},val:function(){return gx.fn.getControlValue("vCEMPLEADOSAREAID")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"EMPLEADOSNOMEMPLEFILTERCONTAINER",grid:0};n[30]={fld:"",grid:0};n[31]={fld:"",grid:0};n[32]={fld:"LBLEMPLEADOSNOMEMPLEFILTER",format:1,grid:0};n[33]={fld:"",grid:0};n[34]={fld:"",grid:0};n[35]={fld:"",grid:0};n[36]={lvl:0,type:"svchar",len:30,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCEMPLEADOSNOMEMPLE",gxz:"ZV8cempleadosnomemple",gxold:"OV8cempleadosnomemple",gxvar:"AV8cempleadosnomemple",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cempleadosnomemple=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cempleadosnomemple=n)},v2c:function(){gx.fn.setControlValue("vCEMPLEADOSNOMEMPLE",gx.O.AV8cempleadosnomemple,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cempleadosnomemple=this.val())},val:function(){return gx.fn.getControlValue("vCEMPLEADOSNOMEMPLE")},nac:gx.falseFn};n[37]={fld:"",grid:0};n[38]={fld:"",grid:0};n[39]={fld:"EMPLEADOSAPPATERNOFILTERCONTAINER",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={fld:"LBLEMPLEADOSAPPATERNOFILTER",format:1,grid:0};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"svchar",len:30,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCEMPLEADOSAPPATERNO",gxz:"ZV9cempleadosappaterno",gxold:"OV9cempleadosappaterno",gxvar:"AV9cempleadosappaterno",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9cempleadosappaterno=n)},v2z:function(n){n!==undefined&&(gx.O.ZV9cempleadosappaterno=n)},v2c:function(){gx.fn.setControlValue("vCEMPLEADOSAPPATERNO",gx.O.AV9cempleadosappaterno,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9cempleadosappaterno=this.val())},val:function(){return gx.fn.getControlValue("vCEMPLEADOSAPPATERNO")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"EMPLEADOSAPMATERNOFILTERCONTAINER",grid:0};n[50]={fld:"",grid:0};n[51]={fld:"",grid:0};n[52]={fld:"LBLEMPLEADOSAPMATERNOFILTER",format:1,grid:0};n[53]={fld:"",grid:0};n[54]={fld:"",grid:0};n[55]={fld:"",grid:0};n[56]={lvl:0,type:"svchar",len:30,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCEMPLEADOSAPMATERNO",gxz:"ZV10cempleadosapmaterno",gxold:"OV10cempleadosapmaterno",gxvar:"AV10cempleadosapmaterno",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10cempleadosapmaterno=n)},v2z:function(n){n!==undefined&&(gx.O.ZV10cempleadosapmaterno=n)},v2c:function(){gx.fn.setControlValue("vCEMPLEADOSAPMATERNO",gx.O.AV10cempleadosapmaterno,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10cempleadosapmaterno=this.val())},val:function(){return gx.fn.getControlValue("vCEMPLEADOSAPMATERNO")},nac:gx.falseFn};n[57]={fld:"",grid:0};n[58]={fld:"",grid:0};n[59]={fld:"EMPLEADOSSTATUSFILTERCONTAINER",grid:0};n[60]={fld:"",grid:0};n[61]={fld:"",grid:0};n[62]={fld:"LBLEMPLEADOSSTATUSFILTER",format:1,grid:0};n[63]={fld:"",grid:0};n[64]={fld:"",grid:0};n[65]={fld:"",grid:0};n[66]={lvl:0,type:"svchar",len:1,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCEMPLEADOSSTATUS",gxz:"ZV11cempleadosstatus",gxold:"OV11cempleadosstatus",gxvar:"AV11cempleadosstatus",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11cempleadosstatus=n)},v2z:function(n){n!==undefined&&(gx.O.ZV11cempleadosstatus=n)},v2c:function(){gx.fn.setControlValue("vCEMPLEADOSSTATUS",gx.O.AV11cempleadosstatus,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11cempleadosstatus=this.val())},val:function(){return gx.fn.getControlValue("vCEMPLEADOSSTATUS")},nac:gx.falseFn};n[67]={fld:"",grid:0};n[68]={fld:"",grid:0};n[69]={fld:"EMPLEADOSUSUARIOFILTERCONTAINER",grid:0};n[70]={fld:"",grid:0};n[71]={fld:"",grid:0};n[72]={fld:"LBLEMPLEADOSUSUARIOFILTER",format:1,grid:0};n[73]={fld:"",grid:0};n[74]={fld:"",grid:0};n[75]={fld:"",grid:0};n[76]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCEMPLEADOSUSUARIO",gxz:"ZV12cempleadosusuario",gxold:"OV12cempleadosusuario",gxvar:"AV12cempleadosusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV12cempleadosusuario=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12cempleadosusuario=n)},v2c:function(){gx.fn.setControlValue("vCEMPLEADOSUSUARIO",gx.O.AV12cempleadosusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV12cempleadosusuario=this.val())},val:function(){return gx.fn.getControlValue("vCEMPLEADOSUSUARIO")},nac:gx.falseFn};n[77]={fld:"",grid:0};n[78]={fld:"GRIDTABLE",grid:0};n[79]={fld:"",grid:0};n[80]={fld:"",grid:0};n[82]={fld:"",grid:0};n[83]={fld:"",grid:0};n[85]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84),gx.O.AV5LinkSelection,gx.O.AV17Linkselection_GXI)},c2v:function(){gx.O.AV17Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(84))},gxvar_GXI:"AV17Linkselection_GXI",nac:gx.falseFn};n[86]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSID",gxz:"Z13empleadosid",gxold:"O13empleadosid",gxvar:"A13empleadosid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A13empleadosid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z13empleadosid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("EMPLEADOSID",n||gx.fn.currentGridRowImpl(84),gx.O.A13empleadosid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A13empleadosid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("EMPLEADOSID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[87]={lvl:2,type:"svchar",len:3,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSAREAID",gxz:"Z98empleadosareaid",gxold:"O98empleadosareaid",gxvar:"A98empleadosareaid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A98empleadosareaid=n)},v2z:function(n){n!==undefined&&(gx.O.Z98empleadosareaid=n)},v2c:function(n){gx.fn.setGridControlValue("EMPLEADOSAREAID",n||gx.fn.currentGridRowImpl(84),gx.O.A98empleadosareaid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A98empleadosareaid=this.val())},val:function(n){return gx.fn.getGridControlValue("EMPLEADOSAREAID",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[88]={lvl:2,type:"svchar",len:30,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSNOMEMPLE",gxz:"Z99empleadosnomemple",gxold:"O99empleadosnomemple",gxvar:"A99empleadosnomemple",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A99empleadosnomemple=n)},v2z:function(n){n!==undefined&&(gx.O.Z99empleadosnomemple=n)},v2c:function(n){gx.fn.setGridControlValue("EMPLEADOSNOMEMPLE",n||gx.fn.currentGridRowImpl(84),gx.O.A99empleadosnomemple,0)},c2v:function(){this.val()!==undefined&&(gx.O.A99empleadosnomemple=this.val())},val:function(n){return gx.fn.getGridControlValue("EMPLEADOSNOMEMPLE",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[89]={lvl:2,type:"svchar",len:30,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSAPPATERNO",gxz:"Z100empleadosappaterno",gxold:"O100empleadosappaterno",gxvar:"A100empleadosappaterno",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A100empleadosappaterno=n)},v2z:function(n){n!==undefined&&(gx.O.Z100empleadosappaterno=n)},v2c:function(n){gx.fn.setGridControlValue("EMPLEADOSAPPATERNO",n||gx.fn.currentGridRowImpl(84),gx.O.A100empleadosappaterno,0)},c2v:function(){this.val()!==undefined&&(gx.O.A100empleadosappaterno=this.val())},val:function(n){return gx.fn.getGridControlValue("EMPLEADOSAPPATERNO",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[90]={lvl:2,type:"svchar",len:30,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSAPMATERNO",gxz:"Z101empleadosapmaterno",gxold:"O101empleadosapmaterno",gxvar:"A101empleadosapmaterno",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A101empleadosapmaterno=n)},v2z:function(n){n!==undefined&&(gx.O.Z101empleadosapmaterno=n)},v2c:function(n){gx.fn.setGridControlValue("EMPLEADOSAPMATERNO",n||gx.fn.currentGridRowImpl(84),gx.O.A101empleadosapmaterno,0)},c2v:function(){this.val()!==undefined&&(gx.O.A101empleadosapmaterno=this.val())},val:function(n){return gx.fn.getGridControlValue("EMPLEADOSAPMATERNO",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[91]={fld:"",grid:0};n[92]={fld:"",grid:0};this.AV6cempleadosid=0;this.ZV6cempleadosid=0;this.OV6cempleadosid=0;this.AV7cempleadosareaid="";this.ZV7cempleadosareaid="";this.OV7cempleadosareaid="";this.AV8cempleadosnomemple="";this.ZV8cempleadosnomemple="";this.OV8cempleadosnomemple="";this.AV9cempleadosappaterno="";this.ZV9cempleadosappaterno="";this.OV9cempleadosappaterno="";this.AV10cempleadosapmaterno="";this.ZV10cempleadosapmaterno="";this.OV10cempleadosapmaterno="";this.AV11cempleadosstatus="";this.ZV11cempleadosstatus="";this.OV11cempleadosstatus="";this.AV12cempleadosusuario="";this.ZV12cempleadosusuario="";this.OV12cempleadosusuario="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z13empleadosid=0;this.O13empleadosid=0;this.Z98empleadosareaid="";this.O98empleadosareaid="";this.Z99empleadosnomemple="";this.O99empleadosnomemple="";this.Z100empleadosappaterno="";this.O100empleadosappaterno="";this.Z101empleadosapmaterno="";this.O101empleadosapmaterno="";this.AV6cempleadosid=0;this.AV7cempleadosareaid="";this.AV8cempleadosnomemple="";this.AV9cempleadosappaterno="";this.AV10cempleadosapmaterno="";this.AV11cempleadosstatus="";this.AV12cempleadosusuario="";this.AV13pempleadosid=0;this.A103empleadosusuario="";this.A102empleadosstatus="";this.AV5LinkSelection="";this.A13empleadosid=0;this.A98empleadosareaid="";this.A99empleadosnomemple="";this.A100empleadosappaterno="";this.A101empleadosapmaterno="";this.Events={e211v2_client:["ENTER",!0],e221v1_client:["CANCEL",!0],e181v1_client:["'TOGGLE'",!1],e111v1_client:["LBLEMPLEADOSIDFILTER.CLICK",!1],e121v1_client:["LBLEMPLEADOSAREAIDFILTER.CLICK",!1],e131v1_client:["LBLEMPLEADOSNOMEMPLEFILTER.CLICK",!1],e141v1_client:["LBLEMPLEADOSAPPATERNOFILTER.CLICK",!1],e151v1_client:["LBLEMPLEADOSAPMATERNOFILTER.CLICK",!1],e161v1_client:["LBLEMPLEADOSSTATUSFILTER.CLICK",!1],e171v1_client:["LBLEMPLEADOSUSUARIOFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cempleadosid",fld:"vCEMPLEADOSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cempleadosareaid",fld:"vCEMPLEADOSAREAID",pic:"",nv:""},{av:"AV8cempleadosnomemple",fld:"vCEMPLEADOSNOMEMPLE",pic:"",nv:""},{av:"AV9cempleadosappaterno",fld:"vCEMPLEADOSAPPATERNO",pic:"",nv:""},{av:"AV10cempleadosapmaterno",fld:"vCEMPLEADOSAPMATERNO",pic:"",nv:""},{av:"AV11cempleadosstatus",fld:"vCEMPLEADOSSTATUS",pic:"",nv:""},{av:"AV12cempleadosusuario",fld:"vCEMPLEADOSUSUARIO",pic:"",nv:""}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLEMPLEADOSIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("EMPLEADOSIDFILTERCONTAINER","Class")',ctrl:"EMPLEADOSIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("EMPLEADOSIDFILTERCONTAINER","Class")',ctrl:"EMPLEADOSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPLEADOSID","Visible")',ctrl:"vCEMPLEADOSID",prop:"Visible"}]];this.EvtParms["LBLEMPLEADOSAREAIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("EMPLEADOSAREAIDFILTERCONTAINER","Class")',ctrl:"EMPLEADOSAREAIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("EMPLEADOSAREAIDFILTERCONTAINER","Class")',ctrl:"EMPLEADOSAREAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPLEADOSAREAID","Visible")',ctrl:"vCEMPLEADOSAREAID",prop:"Visible"}]];this.EvtParms["LBLEMPLEADOSNOMEMPLEFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("EMPLEADOSNOMEMPLEFILTERCONTAINER","Class")',ctrl:"EMPLEADOSNOMEMPLEFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("EMPLEADOSNOMEMPLEFILTERCONTAINER","Class")',ctrl:"EMPLEADOSNOMEMPLEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPLEADOSNOMEMPLE","Visible")',ctrl:"vCEMPLEADOSNOMEMPLE",prop:"Visible"}]];this.EvtParms["LBLEMPLEADOSAPPATERNOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("EMPLEADOSAPPATERNOFILTERCONTAINER","Class")',ctrl:"EMPLEADOSAPPATERNOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("EMPLEADOSAPPATERNOFILTERCONTAINER","Class")',ctrl:"EMPLEADOSAPPATERNOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPLEADOSAPPATERNO","Visible")',ctrl:"vCEMPLEADOSAPPATERNO",prop:"Visible"}]];this.EvtParms["LBLEMPLEADOSAPMATERNOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("EMPLEADOSAPMATERNOFILTERCONTAINER","Class")',ctrl:"EMPLEADOSAPMATERNOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("EMPLEADOSAPMATERNOFILTERCONTAINER","Class")',ctrl:"EMPLEADOSAPMATERNOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPLEADOSAPMATERNO","Visible")',ctrl:"vCEMPLEADOSAPMATERNO",prop:"Visible"}]];this.EvtParms["LBLEMPLEADOSSTATUSFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("EMPLEADOSSTATUSFILTERCONTAINER","Class")',ctrl:"EMPLEADOSSTATUSFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("EMPLEADOSSTATUSFILTERCONTAINER","Class")',ctrl:"EMPLEADOSSTATUSFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPLEADOSSTATUS","Visible")',ctrl:"vCEMPLEADOSSTATUS",prop:"Visible"}]];this.EvtParms["LBLEMPLEADOSUSUARIOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("EMPLEADOSUSUARIOFILTERCONTAINER","Class")',ctrl:"EMPLEADOSUSUARIOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("EMPLEADOSUSUARIOFILTERCONTAINER","Class")',ctrl:"EMPLEADOSUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCEMPLEADOSUSUARIO","Visible")',ctrl:"vCEMPLEADOSUSUARIO",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A13empleadosid",fld:"EMPLEADOSID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV13pempleadosid",fld:"vPEMPLEADOSID",pic:"ZZZZZZZZ9",nv:0}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cempleadosid",fld:"vCEMPLEADOSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cempleadosareaid",fld:"vCEMPLEADOSAREAID",pic:"",nv:""},{av:"AV8cempleadosnomemple",fld:"vCEMPLEADOSNOMEMPLE",pic:"",nv:""},{av:"AV9cempleadosappaterno",fld:"vCEMPLEADOSAPPATERNO",pic:"",nv:""},{av:"AV10cempleadosapmaterno",fld:"vCEMPLEADOSAPMATERNO",pic:"",nv:""},{av:"AV11cempleadosstatus",fld:"vCEMPLEADOSSTATUS",pic:"",nv:""},{av:"AV12cempleadosusuario",fld:"vCEMPLEADOSUSUARIO",pic:"",nv:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cempleadosid",fld:"vCEMPLEADOSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cempleadosareaid",fld:"vCEMPLEADOSAREAID",pic:"",nv:""},{av:"AV8cempleadosnomemple",fld:"vCEMPLEADOSNOMEMPLE",pic:"",nv:""},{av:"AV9cempleadosappaterno",fld:"vCEMPLEADOSAPPATERNO",pic:"",nv:""},{av:"AV10cempleadosapmaterno",fld:"vCEMPLEADOSAPMATERNO",pic:"",nv:""},{av:"AV11cempleadosstatus",fld:"vCEMPLEADOSSTATUS",pic:"",nv:""},{av:"AV12cempleadosusuario",fld:"vCEMPLEADOSUSUARIO",pic:"",nv:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cempleadosid",fld:"vCEMPLEADOSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cempleadosareaid",fld:"vCEMPLEADOSAREAID",pic:"",nv:""},{av:"AV8cempleadosnomemple",fld:"vCEMPLEADOSNOMEMPLE",pic:"",nv:""},{av:"AV9cempleadosappaterno",fld:"vCEMPLEADOSAPPATERNO",pic:"",nv:""},{av:"AV10cempleadosapmaterno",fld:"vCEMPLEADOSAPMATERNO",pic:"",nv:""},{av:"AV11cempleadosstatus",fld:"vCEMPLEADOSSTATUS",pic:"",nv:""},{av:"AV12cempleadosusuario",fld:"vCEMPLEADOSUSUARIO",pic:"",nv:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cempleadosid",fld:"vCEMPLEADOSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cempleadosareaid",fld:"vCEMPLEADOSAREAID",pic:"",nv:""},{av:"AV8cempleadosnomemple",fld:"vCEMPLEADOSNOMEMPLE",pic:"",nv:""},{av:"AV9cempleadosappaterno",fld:"vCEMPLEADOSAPPATERNO",pic:"",nv:""},{av:"AV10cempleadosapmaterno",fld:"vCEMPLEADOSAPMATERNO",pic:"",nv:""},{av:"AV11cempleadosstatus",fld:"vCEMPLEADOSSTATUS",pic:"",nv:""},{av:"AV12cempleadosusuario",fld:"vCEMPLEADOSUSUARIO",pic:"",nv:""}],[]];this.setVCMap("AV13pempleadosid","vPEMPLEADOSID",0,"int");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar(this.GXValidFnc[66]);t.addRefreshingVar(this.GXValidFnc[76]);this.InitStandaloneVars()});gx.createParentObj(gx0060)