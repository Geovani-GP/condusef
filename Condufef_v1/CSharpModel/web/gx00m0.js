/**@preserve  GeneXus C# 10_3_15-115824 on 1/27/2022 22:51:46.59
*/
gx.evt.autoSkip=!1;gx.define("gx00m0",!1,function(){var n,t;this.ServerClass="gx00m0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV13pproductoid=gx.fn.getIntegerValue("vPPRODUCTOID",".");this.AV14pcambsid=gx.fn.getIntegerValue("vPCAMBSID",".")};this.e182p1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle"));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}])};this.e112p1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("PRODUCTOIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PRODUCTOIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPRODUCTOID","Visible",!0)):(gx.fn.setCtrlProperty("PRODUCTOIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPRODUCTOID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PRODUCTOIDFILTERCONTAINER","Class")',ctrl:"PRODUCTOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRODUCTOID","Visible")',ctrl:"vCPRODUCTOID",prop:"Visible"}])};this.e122p1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("CAMBSIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CAMBSIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCAMBSID","Visible",!0)):(gx.fn.setCtrlProperty("CAMBSIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCAMBSID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CAMBSIDFILTERCONTAINER","Class")',ctrl:"CAMBSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCAMBSID","Visible")',ctrl:"vCCAMBSID",prop:"Visible"}])};this.e132p1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("MODELOIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MODELOIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMODELOID","Visible",!0)):(gx.fn.setCtrlProperty("MODELOIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMODELOID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MODELOIDFILTERCONTAINER","Class")',ctrl:"MODELOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMODELOID","Visible")',ctrl:"vCMODELOID",prop:"Visible"}])};this.e142p1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("MARCAIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MARCAIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMARCAID","Visible",!0)):(gx.fn.setCtrlProperty("MARCAIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMARCAID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MARCAIDFILTERCONTAINER","Class")',ctrl:"MARCAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMARCAID","Visible")',ctrl:"vCMARCAID",prop:"Visible"}])};this.e152p1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("CATEGORIAIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CATEGORIAIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCATEGORIAID","Visible",!0)):(gx.fn.setCtrlProperty("CATEGORIAIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCATEGORIAID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CATEGORIAIDFILTERCONTAINER","Class")',ctrl:"CATEGORIAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCATEGORIAID","Visible")',ctrl:"vCCATEGORIAID",prop:"Visible"}])};this.e162p1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("PRODUCTODSCFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PRODUCTODSCFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPRODUCTODSC","Visible",!0)):(gx.fn.setCtrlProperty("PRODUCTODSCFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPRODUCTODSC","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PRODUCTODSCFILTERCONTAINER","Class")',ctrl:"PRODUCTODSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRODUCTODSC","Visible")',ctrl:"vCPRODUCTODSC",prop:"Visible"}])};this.e172p1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("PRODUCTOUSUARIOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PRODUCTOUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPRODUCTOUSUARIO","Visible",!0)):(gx.fn.setCtrlProperty("PRODUCTOUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPRODUCTOUSUARIO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PRODUCTOUSUARIOFILTERCONTAINER","Class")',ctrl:"PRODUCTOUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRODUCTOUSUARIO","Visible")',ctrl:"vCPRODUCTOUSUARIO",prop:"Visible"}])};this.e212p2_client=function(){this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e222p1_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,82,83,85,86,87,88,89,90,91,92,93,94];this.GXLastCtrlId=94;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",84,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00m0",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",85,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(175,86,"PRODUCTOID","productoid","","productoid","int",0,"px",4,4,"right",null,[],175,"productoid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(25,87,"CAMBSID","cambsid","","cambsid","int",0,"px",9,9,"right",null,[],25,"cambsid",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(88,88,"MODELOID","modeloid","","modeloid","int",0,"px",18,18,"right",null,[],88,"modeloid",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(89,89,"MARCAID","marcaid","","marcaid","int",0,"px",18,18,"right",null,[],89,"marcaid",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(90,90,"CATEGORIAID","categoriaid","","categoriaid","int",0,"px",18,18,"right",null,[],90,"categoriaid",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(91,91,"PRODUCTOUSUARIO","productousuario","","productousuario","svchar",0,"px",15,15,"left",null,[],91,"productousuario",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(92,92,"PRODUCTOFECREG","productofecreg","","productofecreg","dtime",0,"px",19,19,"right",null,[],92,"productofecreg",!0,8,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.setGrid(t);n[2]={fld:"",grid:0};n[3]={fld:"MAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"ADVANCEDCONTAINER",grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"PRODUCTOIDFILTERCONTAINER",grid:0};n[10]={fld:"",grid:0};n[11]={fld:"",grid:0};n[12]={fld:"LBLPRODUCTOIDFILTER",format:1,grid:0};n[13]={fld:"",grid:0};n[14]={fld:"",grid:0};n[15]={fld:"",grid:0};n[16]={lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPRODUCTOID",gxz:"ZV6cproductoid",gxold:"OV6cproductoid",gxvar:"AV6cproductoid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cproductoid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cproductoid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCPRODUCTOID",gx.O.AV6cproductoid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cproductoid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCPRODUCTOID",".")},nac:gx.falseFn};n[17]={fld:"",grid:0};n[18]={fld:"",grid:0};n[19]={fld:"CAMBSIDFILTERCONTAINER",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={fld:"LBLCAMBSIDFILTER",format:1,grid:0};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCAMBSID",gxz:"ZV7ccambsid",gxold:"OV7ccambsid",gxvar:"AV7ccambsid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7ccambsid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7ccambsid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCCAMBSID",gx.O.AV7ccambsid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7ccambsid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCCAMBSID",".")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"MODELOIDFILTERCONTAINER",grid:0};n[30]={fld:"",grid:0};n[31]={fld:"",grid:0};n[32]={fld:"LBLMODELOIDFILTER",format:1,grid:0};n[33]={fld:"",grid:0};n[34]={fld:"",grid:0};n[35]={fld:"",grid:0};n[36]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMODELOID",gxz:"ZV8cmodeloid",gxold:"OV8cmodeloid",gxvar:"AV8cmodeloid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cmodeloid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV8cmodeloid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCMODELOID",gx.O.AV8cmodeloid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cmodeloid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCMODELOID",".")},nac:gx.falseFn};n[37]={fld:"",grid:0};n[38]={fld:"",grid:0};n[39]={fld:"MARCAIDFILTERCONTAINER",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={fld:"LBLMARCAIDFILTER",format:1,grid:0};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMARCAID",gxz:"ZV9cmarcaid",gxold:"OV9cmarcaid",gxvar:"AV9cmarcaid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9cmarcaid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV9cmarcaid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCMARCAID",gx.O.AV9cmarcaid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9cmarcaid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCMARCAID",".")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"CATEGORIAIDFILTERCONTAINER",grid:0};n[50]={fld:"",grid:0};n[51]={fld:"",grid:0};n[52]={fld:"LBLCATEGORIAIDFILTER",format:1,grid:0};n[53]={fld:"",grid:0};n[54]={fld:"",grid:0};n[55]={fld:"",grid:0};n[56]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCATEGORIAID",gxz:"ZV10ccategoriaid",gxold:"OV10ccategoriaid",gxvar:"AV10ccategoriaid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10ccategoriaid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV10ccategoriaid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCCATEGORIAID",gx.O.AV10ccategoriaid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10ccategoriaid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCCATEGORIAID",".")},nac:gx.falseFn};n[57]={fld:"",grid:0};n[58]={fld:"",grid:0};n[59]={fld:"PRODUCTODSCFILTERCONTAINER",grid:0};n[60]={fld:"",grid:0};n[61]={fld:"",grid:0};n[62]={fld:"LBLPRODUCTODSCFILTER",format:1,grid:0};n[63]={fld:"",grid:0};n[64]={fld:"",grid:0};n[65]={fld:"",grid:0};n[66]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPRODUCTODSC",gxz:"ZV11cproductodsc",gxold:"OV11cproductodsc",gxvar:"AV11cproductodsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11cproductodsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV11cproductodsc=n)},v2c:function(){gx.fn.setControlValue("vCPRODUCTODSC",gx.O.AV11cproductodsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11cproductodsc=this.val())},val:function(){return gx.fn.getControlValue("vCPRODUCTODSC")},nac:gx.falseFn};n[67]={fld:"",grid:0};n[68]={fld:"",grid:0};n[69]={fld:"PRODUCTOUSUARIOFILTERCONTAINER",grid:0};n[70]={fld:"",grid:0};n[71]={fld:"",grid:0};n[72]={fld:"LBLPRODUCTOUSUARIOFILTER",format:1,grid:0};n[73]={fld:"",grid:0};n[74]={fld:"",grid:0};n[75]={fld:"",grid:0};n[76]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPRODUCTOUSUARIO",gxz:"ZV12cproductousuario",gxold:"OV12cproductousuario",gxvar:"AV12cproductousuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV12cproductousuario=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12cproductousuario=n)},v2c:function(){gx.fn.setControlValue("vCPRODUCTOUSUARIO",gx.O.AV12cproductousuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV12cproductousuario=this.val())},val:function(){return gx.fn.getControlValue("vCPRODUCTOUSUARIO")},nac:gx.falseFn};n[77]={fld:"",grid:0};n[78]={fld:"GRIDTABLE",grid:0};n[79]={fld:"",grid:0};n[80]={fld:"",grid:0};n[82]={fld:"",grid:0};n[83]={fld:"",grid:0};n[85]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84),gx.O.AV5LinkSelection,gx.O.AV18Linkselection_GXI)},c2v:function(){gx.O.AV18Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(84))},gxvar_GXI:"AV18Linkselection_GXI",nac:gx.falseFn};n[86]={lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PRODUCTOID",gxz:"Z175productoid",gxold:"O175productoid",gxvar:"A175productoid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A175productoid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z175productoid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("PRODUCTOID",n||gx.fn.currentGridRowImpl(84),gx.O.A175productoid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A175productoid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PRODUCTOID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[87]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"CAMBSID",gxz:"Z25cambsid",gxold:"O25cambsid",gxvar:"A25cambsid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A25cambsid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z25cambsid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CAMBSID",n||gx.fn.currentGridRowImpl(84),gx.O.A25cambsid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A25cambsid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("CAMBSID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[88]={lvl:2,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MODELOID",gxz:"Z88modeloid",gxold:"O88modeloid",gxvar:"A88modeloid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A88modeloid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z88modeloid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("MODELOID",n||gx.fn.currentGridRowImpl(84),gx.O.A88modeloid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A88modeloid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("MODELOID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[89]={lvl:2,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MARCAID",gxz:"Z89marcaid",gxold:"O89marcaid",gxvar:"A89marcaid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A89marcaid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z89marcaid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("MARCAID",n||gx.fn.currentGridRowImpl(84),gx.O.A89marcaid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A89marcaid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("MARCAID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[90]={lvl:2,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"CATEGORIAID",gxz:"Z90categoriaid",gxold:"O90categoriaid",gxvar:"A90categoriaid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A90categoriaid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z90categoriaid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CATEGORIAID",n||gx.fn.currentGridRowImpl(84),gx.O.A90categoriaid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A90categoriaid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("CATEGORIAID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[91]={lvl:2,type:"svchar",len:15,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PRODUCTOUSUARIO",gxz:"Z91productousuario",gxold:"O91productousuario",gxvar:"A91productousuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A91productousuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z91productousuario=n)},v2c:function(n){gx.fn.setGridControlValue("PRODUCTOUSUARIO",n||gx.fn.currentGridRowImpl(84),gx.O.A91productousuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A91productousuario=this.val())},val:function(n){return gx.fn.getGridControlValue("PRODUCTOUSUARIO",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[92]={lvl:2,type:"dtime",len:10,dec:8,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PRODUCTOFECREG",gxz:"Z92productofecreg",gxold:"O92productofecreg",gxvar:"A92productofecreg",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A92productofecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z92productofecreg=gx.fn.toDatetimeValue(n))},v2c:function(n){gx.fn.setGridControlValue("PRODUCTOFECREG",n||gx.fn.currentGridRowImpl(84),gx.O.A92productofecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A92productofecreg=gx.fn.toDatetimeValue(this.val()))},val:function(n){return gx.fn.getGridDateTimeValue("PRODUCTOFECREG",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[93]={fld:"",grid:0};n[94]={fld:"",grid:0};this.AV6cproductoid=0;this.ZV6cproductoid=0;this.OV6cproductoid=0;this.AV7ccambsid=0;this.ZV7ccambsid=0;this.OV7ccambsid=0;this.AV8cmodeloid=0;this.ZV8cmodeloid=0;this.OV8cmodeloid=0;this.AV9cmarcaid=0;this.ZV9cmarcaid=0;this.OV9cmarcaid=0;this.AV10ccategoriaid=0;this.ZV10ccategoriaid=0;this.OV10ccategoriaid=0;this.AV11cproductodsc="";this.ZV11cproductodsc="";this.OV11cproductodsc="";this.AV12cproductousuario="";this.ZV12cproductousuario="";this.OV12cproductousuario="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z175productoid=0;this.O175productoid=0;this.Z25cambsid=0;this.O25cambsid=0;this.Z88modeloid=0;this.O88modeloid=0;this.Z89marcaid=0;this.O89marcaid=0;this.Z90categoriaid=0;this.O90categoriaid=0;this.Z91productousuario="";this.O91productousuario="";this.Z92productofecreg=gx.date.nullDate();this.O92productofecreg=gx.date.nullDate();this.AV6cproductoid=0;this.AV7ccambsid=0;this.AV8cmodeloid=0;this.AV9cmarcaid=0;this.AV10ccategoriaid=0;this.AV11cproductodsc="";this.AV12cproductousuario="";this.AV13pproductoid=0;this.AV14pcambsid=0;this.A87productodsc="";this.AV5LinkSelection="";this.A175productoid=0;this.A25cambsid=0;this.A88modeloid=0;this.A89marcaid=0;this.A90categoriaid=0;this.A91productousuario="";this.A92productofecreg=gx.date.nullDate();this.Events={e212p2_client:["ENTER",!0],e222p1_client:["CANCEL",!0],e182p1_client:["'TOGGLE'",!1],e112p1_client:["LBLPRODUCTOIDFILTER.CLICK",!1],e122p1_client:["LBLCAMBSIDFILTER.CLICK",!1],e132p1_client:["LBLMODELOIDFILTER.CLICK",!1],e142p1_client:["LBLMARCAIDFILTER.CLICK",!1],e152p1_client:["LBLCATEGORIAIDFILTER.CLICK",!1],e162p1_client:["LBLPRODUCTODSCFILTER.CLICK",!1],e172p1_client:["LBLPRODUCTOUSUARIOFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cproductoid",fld:"vCPRODUCTOID",pic:"ZZZ9",nv:0},{av:"AV7ccambsid",fld:"vCCAMBSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8cmodeloid",fld:"vCMODELOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV9cmarcaid",fld:"vCMARCAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10ccategoriaid",fld:"vCCATEGORIAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11cproductodsc",fld:"vCPRODUCTODSC",pic:"",nv:""},{av:"AV12cproductousuario",fld:"vCPRODUCTOUSUARIO",pic:"",nv:""}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLPRODUCTOIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PRODUCTOIDFILTERCONTAINER","Class")',ctrl:"PRODUCTOIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PRODUCTOIDFILTERCONTAINER","Class")',ctrl:"PRODUCTOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRODUCTOID","Visible")',ctrl:"vCPRODUCTOID",prop:"Visible"}]];this.EvtParms["LBLCAMBSIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CAMBSIDFILTERCONTAINER","Class")',ctrl:"CAMBSIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CAMBSIDFILTERCONTAINER","Class")',ctrl:"CAMBSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCAMBSID","Visible")',ctrl:"vCCAMBSID",prop:"Visible"}]];this.EvtParms["LBLMODELOIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MODELOIDFILTERCONTAINER","Class")',ctrl:"MODELOIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MODELOIDFILTERCONTAINER","Class")',ctrl:"MODELOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMODELOID","Visible")',ctrl:"vCMODELOID",prop:"Visible"}]];this.EvtParms["LBLMARCAIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MARCAIDFILTERCONTAINER","Class")',ctrl:"MARCAIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MARCAIDFILTERCONTAINER","Class")',ctrl:"MARCAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMARCAID","Visible")',ctrl:"vCMARCAID",prop:"Visible"}]];this.EvtParms["LBLCATEGORIAIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CATEGORIAIDFILTERCONTAINER","Class")',ctrl:"CATEGORIAIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CATEGORIAIDFILTERCONTAINER","Class")',ctrl:"CATEGORIAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCATEGORIAID","Visible")',ctrl:"vCCATEGORIAID",prop:"Visible"}]];this.EvtParms["LBLPRODUCTODSCFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PRODUCTODSCFILTERCONTAINER","Class")',ctrl:"PRODUCTODSCFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PRODUCTODSCFILTERCONTAINER","Class")',ctrl:"PRODUCTODSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRODUCTODSC","Visible")',ctrl:"vCPRODUCTODSC",prop:"Visible"}]];this.EvtParms["LBLPRODUCTOUSUARIOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PRODUCTOUSUARIOFILTERCONTAINER","Class")',ctrl:"PRODUCTOUSUARIOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PRODUCTOUSUARIOFILTERCONTAINER","Class")',ctrl:"PRODUCTOUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPRODUCTOUSUARIO","Visible")',ctrl:"vCPRODUCTOUSUARIO",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A175productoid",fld:"PRODUCTOID",pic:"ZZZ9",hsh:!0,nv:0},{av:"A25cambsid",fld:"CAMBSID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV13pproductoid",fld:"vPPRODUCTOID",pic:"ZZZ9",nv:0},{av:"AV14pcambsid",fld:"vPCAMBSID",pic:"ZZZZZZZZ9",nv:0}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cproductoid",fld:"vCPRODUCTOID",pic:"ZZZ9",nv:0},{av:"AV7ccambsid",fld:"vCCAMBSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8cmodeloid",fld:"vCMODELOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV9cmarcaid",fld:"vCMARCAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10ccategoriaid",fld:"vCCATEGORIAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11cproductodsc",fld:"vCPRODUCTODSC",pic:"",nv:""},{av:"AV12cproductousuario",fld:"vCPRODUCTOUSUARIO",pic:"",nv:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cproductoid",fld:"vCPRODUCTOID",pic:"ZZZ9",nv:0},{av:"AV7ccambsid",fld:"vCCAMBSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8cmodeloid",fld:"vCMODELOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV9cmarcaid",fld:"vCMARCAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10ccategoriaid",fld:"vCCATEGORIAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11cproductodsc",fld:"vCPRODUCTODSC",pic:"",nv:""},{av:"AV12cproductousuario",fld:"vCPRODUCTOUSUARIO",pic:"",nv:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cproductoid",fld:"vCPRODUCTOID",pic:"ZZZ9",nv:0},{av:"AV7ccambsid",fld:"vCCAMBSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8cmodeloid",fld:"vCMODELOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV9cmarcaid",fld:"vCMARCAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10ccategoriaid",fld:"vCCATEGORIAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11cproductodsc",fld:"vCPRODUCTODSC",pic:"",nv:""},{av:"AV12cproductousuario",fld:"vCPRODUCTOUSUARIO",pic:"",nv:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cproductoid",fld:"vCPRODUCTOID",pic:"ZZZ9",nv:0},{av:"AV7ccambsid",fld:"vCCAMBSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8cmodeloid",fld:"vCMODELOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV9cmarcaid",fld:"vCMARCAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10ccategoriaid",fld:"vCCATEGORIAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11cproductodsc",fld:"vCPRODUCTODSC",pic:"",nv:""},{av:"AV12cproductousuario",fld:"vCPRODUCTOUSUARIO",pic:"",nv:""}],[]];this.setVCMap("AV13pproductoid","vPPRODUCTOID",0,"int");this.setVCMap("AV14pcambsid","vPCAMBSID",0,"int");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar(this.GXValidFnc[66]);t.addRefreshingVar(this.GXValidFnc[76]);this.InitStandaloneVars()});gx.createParentObj(gx00m0)