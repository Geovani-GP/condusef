/**@preserve  GeneXus C# 10_3_15-115824 on 12/30/2021 22:9:27.53
*/
gx.evt.autoSkip=!1;gx.define("gx0090",!1,function(){var n,t;this.ServerClass="gx0090";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV13pmodelosid=gx.fn.getIntegerValue("vPMODELOSID",".");this.AV14pproductocambsid=gx.fn.getControlValue("vPPRODUCTOCAMBSID")};this.e180f1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle"));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}])};this.e110f1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("MODELOSIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MODELOSIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMODELOSID","Visible",!0)):(gx.fn.setCtrlProperty("MODELOSIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMODELOSID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MODELOSIDFILTERCONTAINER","Class")',ctrl:"MODELOSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMODELOSID","Visible")',ctrl:"vCMODELOSID",prop:"Visible"}])};this.e120f1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("PRODUCTOCAMBSIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PRODUCTOCAMBSIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPRODUCTOCAMBSID","Visible",!0)):(gx.fn.setCtrlProperty("PRODUCTOCAMBSIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPRODUCTOCAMBSID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PRODUCTOCAMBSIDFILTERCONTAINER","Class")',ctrl:"PRODUCTOCAMBSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRODUCTOCAMBSID","Visible")',ctrl:"vCPRODUCTOCAMBSID",prop:"Visible"}])};this.e130f1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("PRODUCTODSCFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PRODUCTODSCFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPRODUCTODSC","Visible",!0)):(gx.fn.setCtrlProperty("PRODUCTODSCFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPRODUCTODSC","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PRODUCTODSCFILTERCONTAINER","Class")',ctrl:"PRODUCTODSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRODUCTODSC","Visible")',ctrl:"vCPRODUCTODSC",prop:"Visible"}])};this.e140f1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("MODELOIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MODELOIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMODELOID","Visible",!0)):(gx.fn.setCtrlProperty("MODELOIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMODELOID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MODELOIDFILTERCONTAINER","Class")',ctrl:"MODELOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMODELOID","Visible")',ctrl:"vCMODELOID",prop:"Visible"}])};this.e150f1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("MARCAIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MARCAIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMARCAID","Visible",!0)):(gx.fn.setCtrlProperty("MARCAIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMARCAID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MARCAIDFILTERCONTAINER","Class")',ctrl:"MARCAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMARCAID","Visible")',ctrl:"vCMARCAID",prop:"Visible"}])};this.e160f1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("CATEGORIAIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CATEGORIAIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCATEGORIAID","Visible",!0)):(gx.fn.setCtrlProperty("CATEGORIAIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCATEGORIAID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CATEGORIAIDFILTERCONTAINER","Class")',ctrl:"CATEGORIAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCATEGORIAID","Visible")',ctrl:"vCCATEGORIAID",prop:"Visible"}])};this.e170f1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("PRODUCTOUSUARIOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PRODUCTOUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPRODUCTOUSUARIO","Visible",!0)):(gx.fn.setCtrlProperty("PRODUCTOUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPRODUCTOUSUARIO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PRODUCTOUSUARIOFILTERCONTAINER","Class")',ctrl:"PRODUCTOUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRODUCTOUSUARIO","Visible")',ctrl:"vCPRODUCTOUSUARIO",prop:"Visible"}])};this.e210f2_client=function(){this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e220f1_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,82,83,85,86,87,88,89,90];this.GXLastCtrlId=90;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",84,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0090",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",85,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(15,86,"MODELOSID","modelosid","","modelosid","int",0,"px",9,9,"right",null,[],15,"modelosid",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(16,87,"PRODUCTOCAMBSID","cambsid","","productocambsid","svchar",0,"px",10,10,"left",null,[],16,"productocambsid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(87,88,"PRODUCTODSC","productodsc","","productodsc","svchar",0,"px",100,80,"left",null,[],87,"productodsc",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");this.setGrid(t);n[2]={fld:"",grid:0};n[3]={fld:"MAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"ADVANCEDCONTAINER",grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"MODELOSIDFILTERCONTAINER",grid:0};n[10]={fld:"",grid:0};n[11]={fld:"",grid:0};n[12]={fld:"LBLMODELOSIDFILTER",format:1,grid:0};n[13]={fld:"",grid:0};n[14]={fld:"",grid:0};n[15]={fld:"",grid:0};n[16]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMODELOSID",gxz:"ZV6cmodelosid",gxold:"OV6cmodelosid",gxvar:"AV6cmodelosid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cmodelosid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cmodelosid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCMODELOSID",gx.O.AV6cmodelosid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cmodelosid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCMODELOSID",".")},nac:gx.falseFn};n[17]={fld:"",grid:0};n[18]={fld:"",grid:0};n[19]={fld:"PRODUCTOCAMBSIDFILTERCONTAINER",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={fld:"LBLPRODUCTOCAMBSIDFILTER",format:1,grid:0};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPRODUCTOCAMBSID",gxz:"ZV7cproductocambsid",gxold:"OV7cproductocambsid",gxvar:"AV7cproductocambsid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cproductocambsid=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cproductocambsid=n)},v2c:function(){gx.fn.setControlValue("vCPRODUCTOCAMBSID",gx.O.AV7cproductocambsid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cproductocambsid=this.val())},val:function(){return gx.fn.getControlValue("vCPRODUCTOCAMBSID")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"PRODUCTODSCFILTERCONTAINER",grid:0};n[30]={fld:"",grid:0};n[31]={fld:"",grid:0};n[32]={fld:"LBLPRODUCTODSCFILTER",format:1,grid:0};n[33]={fld:"",grid:0};n[34]={fld:"",grid:0};n[35]={fld:"",grid:0};n[36]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPRODUCTODSC",gxz:"ZV8cproductodsc",gxold:"OV8cproductodsc",gxvar:"AV8cproductodsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cproductodsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cproductodsc=n)},v2c:function(){gx.fn.setControlValue("vCPRODUCTODSC",gx.O.AV8cproductodsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cproductodsc=this.val())},val:function(){return gx.fn.getControlValue("vCPRODUCTODSC")},nac:gx.falseFn};n[37]={fld:"",grid:0};n[38]={fld:"",grid:0};n[39]={fld:"MODELOIDFILTERCONTAINER",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={fld:"LBLMODELOIDFILTER",format:1,grid:0};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMODELOID",gxz:"ZV9cmodeloid",gxold:"OV9cmodeloid",gxvar:"AV9cmodeloid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9cmodeloid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV9cmodeloid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCMODELOID",gx.O.AV9cmodeloid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9cmodeloid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCMODELOID",".")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"MARCAIDFILTERCONTAINER",grid:0};n[50]={fld:"",grid:0};n[51]={fld:"",grid:0};n[52]={fld:"LBLMARCAIDFILTER",format:1,grid:0};n[53]={fld:"",grid:0};n[54]={fld:"",grid:0};n[55]={fld:"",grid:0};n[56]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMARCAID",gxz:"ZV10cmarcaid",gxold:"OV10cmarcaid",gxvar:"AV10cmarcaid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10cmarcaid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV10cmarcaid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCMARCAID",gx.O.AV10cmarcaid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10cmarcaid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCMARCAID",".")},nac:gx.falseFn};n[57]={fld:"",grid:0};n[58]={fld:"",grid:0};n[59]={fld:"CATEGORIAIDFILTERCONTAINER",grid:0};n[60]={fld:"",grid:0};n[61]={fld:"",grid:0};n[62]={fld:"LBLCATEGORIAIDFILTER",format:1,grid:0};n[63]={fld:"",grid:0};n[64]={fld:"",grid:0};n[65]={fld:"",grid:0};n[66]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCATEGORIAID",gxz:"ZV11ccategoriaid",gxold:"OV11ccategoriaid",gxvar:"AV11ccategoriaid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11ccategoriaid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV11ccategoriaid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCCATEGORIAID",gx.O.AV11ccategoriaid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11ccategoriaid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCCATEGORIAID",".")},nac:gx.falseFn};n[67]={fld:"",grid:0};n[68]={fld:"",grid:0};n[69]={fld:"PRODUCTOUSUARIOFILTERCONTAINER",grid:0};n[70]={fld:"",grid:0};n[71]={fld:"",grid:0};n[72]={fld:"LBLPRODUCTOUSUARIOFILTER",format:1,grid:0};n[73]={fld:"",grid:0};n[74]={fld:"",grid:0};n[75]={fld:"",grid:0};n[76]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPRODUCTOUSUARIO",gxz:"ZV12cproductousuario",gxold:"OV12cproductousuario",gxvar:"AV12cproductousuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV12cproductousuario=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12cproductousuario=n)},v2c:function(){gx.fn.setControlValue("vCPRODUCTOUSUARIO",gx.O.AV12cproductousuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV12cproductousuario=this.val())},val:function(){return gx.fn.getControlValue("vCPRODUCTOUSUARIO")},nac:gx.falseFn};n[77]={fld:"",grid:0};n[78]={fld:"GRIDTABLE",grid:0};n[79]={fld:"",grid:0};n[80]={fld:"",grid:0};n[82]={fld:"",grid:0};n[83]={fld:"",grid:0};n[85]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84),gx.O.AV5LinkSelection,gx.O.AV18Linkselection_GXI)},c2v:function(){gx.O.AV18Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(84))},gxvar_GXI:"AV18Linkselection_GXI",nac:gx.falseFn};n[86]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MODELOSID",gxz:"Z15modelosid",gxold:"O15modelosid",gxvar:"A15modelosid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A15modelosid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z15modelosid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("MODELOSID",n||gx.fn.currentGridRowImpl(84),gx.O.A15modelosid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A15modelosid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("MODELOSID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[87]={lvl:2,type:"svchar",len:10,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PRODUCTOCAMBSID",gxz:"Z16productocambsid",gxold:"O16productocambsid",gxvar:"A16productocambsid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A16productocambsid=n)},v2z:function(n){n!==undefined&&(gx.O.Z16productocambsid=n)},v2c:function(n){gx.fn.setGridControlValue("PRODUCTOCAMBSID",n||gx.fn.currentGridRowImpl(84),gx.O.A16productocambsid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A16productocambsid=this.val())},val:function(n){return gx.fn.getGridControlValue("PRODUCTOCAMBSID",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[88]={lvl:2,type:"svchar",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PRODUCTODSC",gxz:"Z87productodsc",gxold:"O87productodsc",gxvar:"A87productodsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A87productodsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z87productodsc=n)},v2c:function(n){gx.fn.setGridControlValue("PRODUCTODSC",n||gx.fn.currentGridRowImpl(84),gx.O.A87productodsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A87productodsc=this.val())},val:function(n){return gx.fn.getGridControlValue("PRODUCTODSC",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[89]={fld:"",grid:0};n[90]={fld:"",grid:0};this.AV6cmodelosid=0;this.ZV6cmodelosid=0;this.OV6cmodelosid=0;this.AV7cproductocambsid="";this.ZV7cproductocambsid="";this.OV7cproductocambsid="";this.AV8cproductodsc="";this.ZV8cproductodsc="";this.OV8cproductodsc="";this.AV9cmodeloid=0;this.ZV9cmodeloid=0;this.OV9cmodeloid=0;this.AV10cmarcaid=0;this.ZV10cmarcaid=0;this.OV10cmarcaid=0;this.AV11ccategoriaid=0;this.ZV11ccategoriaid=0;this.OV11ccategoriaid=0;this.AV12cproductousuario="";this.ZV12cproductousuario="";this.OV12cproductousuario="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z15modelosid=0;this.O15modelosid=0;this.Z16productocambsid="";this.O16productocambsid="";this.Z87productodsc="";this.O87productodsc="";this.AV6cmodelosid=0;this.AV7cproductocambsid="";this.AV8cproductodsc="";this.AV9cmodeloid=0;this.AV10cmarcaid=0;this.AV11ccategoriaid=0;this.AV12cproductousuario="";this.AV13pmodelosid=0;this.AV14pproductocambsid="";this.A91productousuario="";this.A90categoriaid=0;this.A89marcaid=0;this.A88modeloid=0;this.AV5LinkSelection="";this.A15modelosid=0;this.A16productocambsid="";this.A87productodsc="";this.Events={e210f2_client:["ENTER",!0],e220f1_client:["CANCEL",!0],e180f1_client:["'TOGGLE'",!1],e110f1_client:["LBLMODELOSIDFILTER.CLICK",!1],e120f1_client:["LBLPRODUCTOCAMBSIDFILTER.CLICK",!1],e130f1_client:["LBLPRODUCTODSCFILTER.CLICK",!1],e140f1_client:["LBLMODELOIDFILTER.CLICK",!1],e150f1_client:["LBLMARCAIDFILTER.CLICK",!1],e160f1_client:["LBLCATEGORIAIDFILTER.CLICK",!1],e170f1_client:["LBLPRODUCTOUSUARIOFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cmodelosid",fld:"vCMODELOSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cproductocambsid",fld:"vCPRODUCTOCAMBSID",pic:"",nv:""},{av:"AV8cproductodsc",fld:"vCPRODUCTODSC",pic:"",nv:""},{av:"AV9cmodeloid",fld:"vCMODELOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10cmarcaid",fld:"vCMARCAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11ccategoriaid",fld:"vCCATEGORIAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV12cproductousuario",fld:"vCPRODUCTOUSUARIO",pic:"",nv:""}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLMODELOSIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MODELOSIDFILTERCONTAINER","Class")',ctrl:"MODELOSIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MODELOSIDFILTERCONTAINER","Class")',ctrl:"MODELOSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMODELOSID","Visible")',ctrl:"vCMODELOSID",prop:"Visible"}]];this.EvtParms["LBLPRODUCTOCAMBSIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PRODUCTOCAMBSIDFILTERCONTAINER","Class")',ctrl:"PRODUCTOCAMBSIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PRODUCTOCAMBSIDFILTERCONTAINER","Class")',ctrl:"PRODUCTOCAMBSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRODUCTOCAMBSID","Visible")',ctrl:"vCPRODUCTOCAMBSID",prop:"Visible"}]];this.EvtParms["LBLPRODUCTODSCFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PRODUCTODSCFILTERCONTAINER","Class")',ctrl:"PRODUCTODSCFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PRODUCTODSCFILTERCONTAINER","Class")',ctrl:"PRODUCTODSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRODUCTODSC","Visible")',ctrl:"vCPRODUCTODSC",prop:"Visible"}]];this.EvtParms["LBLMODELOIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MODELOIDFILTERCONTAINER","Class")',ctrl:"MODELOIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MODELOIDFILTERCONTAINER","Class")',ctrl:"MODELOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMODELOID","Visible")',ctrl:"vCMODELOID",prop:"Visible"}]];this.EvtParms["LBLMARCAIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MARCAIDFILTERCONTAINER","Class")',ctrl:"MARCAIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MARCAIDFILTERCONTAINER","Class")',ctrl:"MARCAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMARCAID","Visible")',ctrl:"vCMARCAID",prop:"Visible"}]];this.EvtParms["LBLCATEGORIAIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CATEGORIAIDFILTERCONTAINER","Class")',ctrl:"CATEGORIAIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CATEGORIAIDFILTERCONTAINER","Class")',ctrl:"CATEGORIAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCATEGORIAID","Visible")',ctrl:"vCCATEGORIAID",prop:"Visible"}]];this.EvtParms["LBLPRODUCTOUSUARIOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PRODUCTOUSUARIOFILTERCONTAINER","Class")',ctrl:"PRODUCTOUSUARIOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PRODUCTOUSUARIOFILTERCONTAINER","Class")',ctrl:"PRODUCTOUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRODUCTOUSUARIO","Visible")',ctrl:"vCPRODUCTOUSUARIO",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A15modelosid",fld:"MODELOSID",pic:"ZZZZZZZZ9",hsh:!0,nv:0},{av:"A16productocambsid",fld:"PRODUCTOCAMBSID",pic:"",hsh:!0,nv:""}],[{av:"AV13pmodelosid",fld:"vPMODELOSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV14pproductocambsid",fld:"vPPRODUCTOCAMBSID",pic:"",nv:""}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cmodelosid",fld:"vCMODELOSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cproductocambsid",fld:"vCPRODUCTOCAMBSID",pic:"",nv:""},{av:"AV8cproductodsc",fld:"vCPRODUCTODSC",pic:"",nv:""},{av:"AV9cmodeloid",fld:"vCMODELOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10cmarcaid",fld:"vCMARCAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11ccategoriaid",fld:"vCCATEGORIAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV12cproductousuario",fld:"vCPRODUCTOUSUARIO",pic:"",nv:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cmodelosid",fld:"vCMODELOSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cproductocambsid",fld:"vCPRODUCTOCAMBSID",pic:"",nv:""},{av:"AV8cproductodsc",fld:"vCPRODUCTODSC",pic:"",nv:""},{av:"AV9cmodeloid",fld:"vCMODELOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10cmarcaid",fld:"vCMARCAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11ccategoriaid",fld:"vCCATEGORIAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV12cproductousuario",fld:"vCPRODUCTOUSUARIO",pic:"",nv:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cmodelosid",fld:"vCMODELOSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cproductocambsid",fld:"vCPRODUCTOCAMBSID",pic:"",nv:""},{av:"AV8cproductodsc",fld:"vCPRODUCTODSC",pic:"",nv:""},{av:"AV9cmodeloid",fld:"vCMODELOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10cmarcaid",fld:"vCMARCAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11ccategoriaid",fld:"vCCATEGORIAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV12cproductousuario",fld:"vCPRODUCTOUSUARIO",pic:"",nv:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cmodelosid",fld:"vCMODELOSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cproductocambsid",fld:"vCPRODUCTOCAMBSID",pic:"",nv:""},{av:"AV8cproductodsc",fld:"vCPRODUCTODSC",pic:"",nv:""},{av:"AV9cmodeloid",fld:"vCMODELOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10cmarcaid",fld:"vCMARCAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11ccategoriaid",fld:"vCCATEGORIAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV12cproductousuario",fld:"vCPRODUCTOUSUARIO",pic:"",nv:""}],[]];this.setVCMap("AV13pmodelosid","vPMODELOSID",0,"int");this.setVCMap("AV14pproductocambsid","vPPRODUCTOCAMBSID",0,"svchar");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar(this.GXValidFnc[66]);t.addRefreshingVar(this.GXValidFnc[76]);this.InitStandaloneVars()});gx.createParentObj(gx0090)