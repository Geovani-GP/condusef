/**@preserve  GeneXus C# 10_3_15-115824 on 1/25/2022 17:35:30.75
*/
gx.evt.autoSkip=!1;gx.define("gx00b0",!1,function(){var n,t;this.ServerClass="gx00b0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV13palmacenid=gx.fn.getIntegerValue("vPALMACENID",".");this.AV14particulosproductoid=gx.fn.getIntegerValue("vPARTICULOSPRODUCTOID",".");this.AV15particuloscambsid=gx.fn.getIntegerValue("vPARTICULOSCAMBSID",".")};this.e18211_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle"));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}])};this.e11211_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ALMACENIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ALMACENIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCALMACENID","Visible",!0)):(gx.fn.setCtrlProperty("ALMACENIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCALMACENID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ALMACENIDFILTERCONTAINER","Class")',ctrl:"ALMACENIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCALMACENID","Visible")',ctrl:"vCALMACENID",prop:"Visible"}])};this.e12211_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ARTICULOSPRODUCTOIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ARTICULOSPRODUCTOIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCARTICULOSPRODUCTOID","Visible",!0)):(gx.fn.setCtrlProperty("ARTICULOSPRODUCTOIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCARTICULOSPRODUCTOID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ARTICULOSPRODUCTOIDFILTERCONTAINER","Class")',ctrl:"ARTICULOSPRODUCTOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCARTICULOSPRODUCTOID","Visible")',ctrl:"vCARTICULOSPRODUCTOID",prop:"Visible"}])};this.e13211_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ARTICULOSCAMBSIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ARTICULOSCAMBSIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCARTICULOSCAMBSID","Visible",!0)):(gx.fn.setCtrlProperty("ARTICULOSCAMBSIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCARTICULOSCAMBSID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ARTICULOSCAMBSIDFILTERCONTAINER","Class")',ctrl:"ARTICULOSCAMBSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCARTICULOSCAMBSID","Visible")',ctrl:"vCARTICULOSCAMBSID",prop:"Visible"}])};this.e14211_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ALAMCENIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ALAMCENIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCALAMCENID","Visible",!0)):(gx.fn.setCtrlProperty("ALAMCENIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCALAMCENID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ALAMCENIDFILTERCONTAINER","Class")',ctrl:"ALAMCENIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCALAMCENID","Visible")',ctrl:"vCALAMCENID",prop:"Visible"}])};this.e15211_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ARTICULOSNOETIQUETAFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ARTICULOSNOETIQUETAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCARTICULOSNOETIQUETA","Visible",!0)):(gx.fn.setCtrlProperty("ARTICULOSNOETIQUETAFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCARTICULOSNOETIQUETA","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ARTICULOSNOETIQUETAFILTERCONTAINER","Class")',ctrl:"ARTICULOSNOETIQUETAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCARTICULOSNOETIQUETA","Visible")',ctrl:"vCARTICULOSNOETIQUETA",prop:"Visible"}])};this.e16211_client=function(){this.clearMessages();gx.fn.getCtrlProperty("TIPOBIENIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("TIPOBIENIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCTIPOBIENID","Visible",!0)):(gx.fn.setCtrlProperty("TIPOBIENIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCTIPOBIENID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("TIPOBIENIDFILTERCONTAINER","Class")',ctrl:"TIPOBIENIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTIPOBIENID","Visible")',ctrl:"vCTIPOBIENID",prop:"Visible"}])};this.e17211_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ENTIDAFEDERATIVAIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ENTIDAFEDERATIVAIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCENTIDAFEDERATIVAID","Visible",!0)):(gx.fn.setCtrlProperty("ENTIDAFEDERATIVAIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCENTIDAFEDERATIVAID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ENTIDAFEDERATIVAIDFILTERCONTAINER","Class")',ctrl:"ENTIDAFEDERATIVAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCENTIDAFEDERATIVAID","Visible")',ctrl:"vCENTIDAFEDERATIVAID",prop:"Visible"}])};this.e21212_client=function(){this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e22211_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,82,83,85,86,87,88,89,90,91,92,93,94];this.GXLastCtrlId=94;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",84,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00b0",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",85,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(19,86,"ALMACENID","almacenid","","almacenid","int",0,"px",18,18,"right",null,[],19,"almacenid",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(20,87,"ARTICULOSPRODUCTOID","productoid","","articulosproductoid","int",0,"px",9,9,"right",null,[],20,"articulosproductoid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(21,88,"ARTICULOSCAMBSID","cambsid","","articuloscambsid","int",0,"px",9,9,"right",null,[],21,"articuloscambsid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(154,89,"ALAMCENID","alamcenid","","alamcenid","int",0,"px",18,18,"right",null,[],154,"alamcenid",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(155,90,"ARTICULOSNOETIQUETA","articulosnoetiqueta","","articulosnoetiqueta","int",0,"px",18,18,"right",null,[],155,"articulosnoetiqueta",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(23,91,"TIPOBIENID","tipobienid","","tipobienid","int",0,"px",9,9,"right",null,[],23,"tipobienid",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(7,92,"ENTIDAFEDERATIVAID","entidafederativaid","","entidafederativaid","int",0,"px",9,9,"right",null,[],7,"entidafederativaid",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.setGrid(t);n[2]={fld:"",grid:0};n[3]={fld:"MAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"ADVANCEDCONTAINER",grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"ALMACENIDFILTERCONTAINER",grid:0};n[10]={fld:"",grid:0};n[11]={fld:"",grid:0};n[12]={fld:"LBLALMACENIDFILTER",format:1,grid:0};n[13]={fld:"",grid:0};n[14]={fld:"",grid:0};n[15]={fld:"",grid:0};n[16]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCALMACENID",gxz:"ZV6calmacenid",gxold:"OV6calmacenid",gxvar:"AV6calmacenid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6calmacenid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6calmacenid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCALMACENID",gx.O.AV6calmacenid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6calmacenid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCALMACENID",".")},nac:gx.falseFn};n[17]={fld:"",grid:0};n[18]={fld:"",grid:0};n[19]={fld:"ARTICULOSPRODUCTOIDFILTERCONTAINER",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={fld:"LBLARTICULOSPRODUCTOIDFILTER",format:1,grid:0};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCARTICULOSPRODUCTOID",gxz:"ZV7carticulosproductoid",gxold:"OV7carticulosproductoid",gxvar:"AV7carticulosproductoid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7carticulosproductoid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7carticulosproductoid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCARTICULOSPRODUCTOID",gx.O.AV7carticulosproductoid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7carticulosproductoid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCARTICULOSPRODUCTOID",".")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"ARTICULOSCAMBSIDFILTERCONTAINER",grid:0};n[30]={fld:"",grid:0};n[31]={fld:"",grid:0};n[32]={fld:"LBLARTICULOSCAMBSIDFILTER",format:1,grid:0};n[33]={fld:"",grid:0};n[34]={fld:"",grid:0};n[35]={fld:"",grid:0};n[36]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCARTICULOSCAMBSID",gxz:"ZV8carticuloscambsid",gxold:"OV8carticuloscambsid",gxvar:"AV8carticuloscambsid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8carticuloscambsid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV8carticuloscambsid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCARTICULOSCAMBSID",gx.O.AV8carticuloscambsid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8carticuloscambsid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCARTICULOSCAMBSID",".")},nac:gx.falseFn};n[37]={fld:"",grid:0};n[38]={fld:"",grid:0};n[39]={fld:"ALAMCENIDFILTERCONTAINER",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={fld:"LBLALAMCENIDFILTER",format:1,grid:0};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCALAMCENID",gxz:"ZV9calamcenid",gxold:"OV9calamcenid",gxvar:"AV9calamcenid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9calamcenid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV9calamcenid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCALAMCENID",gx.O.AV9calamcenid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9calamcenid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCALAMCENID",".")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"ARTICULOSNOETIQUETAFILTERCONTAINER",grid:0};n[50]={fld:"",grid:0};n[51]={fld:"",grid:0};n[52]={fld:"LBLARTICULOSNOETIQUETAFILTER",format:1,grid:0};n[53]={fld:"",grid:0};n[54]={fld:"",grid:0};n[55]={fld:"",grid:0};n[56]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCARTICULOSNOETIQUETA",gxz:"ZV10carticulosnoetiqueta",gxold:"OV10carticulosnoetiqueta",gxvar:"AV10carticulosnoetiqueta",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10carticulosnoetiqueta=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV10carticulosnoetiqueta=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCARTICULOSNOETIQUETA",gx.O.AV10carticulosnoetiqueta,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10carticulosnoetiqueta=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCARTICULOSNOETIQUETA",".")},nac:gx.falseFn};n[57]={fld:"",grid:0};n[58]={fld:"",grid:0};n[59]={fld:"TIPOBIENIDFILTERCONTAINER",grid:0};n[60]={fld:"",grid:0};n[61]={fld:"",grid:0};n[62]={fld:"LBLTIPOBIENIDFILTER",format:1,grid:0};n[63]={fld:"",grid:0};n[64]={fld:"",grid:0};n[65]={fld:"",grid:0};n[66]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCTIPOBIENID",gxz:"ZV11ctipobienid",gxold:"OV11ctipobienid",gxvar:"AV11ctipobienid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11ctipobienid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV11ctipobienid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCTIPOBIENID",gx.O.AV11ctipobienid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11ctipobienid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCTIPOBIENID",".")},nac:gx.falseFn};n[67]={fld:"",grid:0};n[68]={fld:"",grid:0};n[69]={fld:"ENTIDAFEDERATIVAIDFILTERCONTAINER",grid:0};n[70]={fld:"",grid:0};n[71]={fld:"",grid:0};n[72]={fld:"LBLENTIDAFEDERATIVAIDFILTER",format:1,grid:0};n[73]={fld:"",grid:0};n[74]={fld:"",grid:0};n[75]={fld:"",grid:0};n[76]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCENTIDAFEDERATIVAID",gxz:"ZV12centidafederativaid",gxold:"OV12centidafederativaid",gxvar:"AV12centidafederativaid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV12centidafederativaid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV12centidafederativaid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCENTIDAFEDERATIVAID",gx.O.AV12centidafederativaid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV12centidafederativaid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCENTIDAFEDERATIVAID",".")},nac:gx.falseFn};n[77]={fld:"",grid:0};n[78]={fld:"GRIDTABLE",grid:0};n[79]={fld:"",grid:0};n[80]={fld:"",grid:0};n[82]={fld:"",grid:0};n[83]={fld:"",grid:0};n[85]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84),gx.O.AV5LinkSelection,gx.O.AV19Linkselection_GXI)},c2v:function(){gx.O.AV19Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(84))},gxvar_GXI:"AV19Linkselection_GXI",nac:gx.falseFn};n[86]={lvl:2,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ALMACENID",gxz:"Z19almacenid",gxold:"O19almacenid",gxvar:"A19almacenid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A19almacenid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z19almacenid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ALMACENID",n||gx.fn.currentGridRowImpl(84),gx.O.A19almacenid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A19almacenid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ALMACENID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[87]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSPRODUCTOID",gxz:"Z20articulosproductoid",gxold:"O20articulosproductoid",gxvar:"A20articulosproductoid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A20articulosproductoid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z20articulosproductoid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ARTICULOSPRODUCTOID",n||gx.fn.currentGridRowImpl(84),gx.O.A20articulosproductoid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A20articulosproductoid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ARTICULOSPRODUCTOID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[88]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSCAMBSID",gxz:"Z21articuloscambsid",gxold:"O21articuloscambsid",gxvar:"A21articuloscambsid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A21articuloscambsid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z21articuloscambsid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ARTICULOSCAMBSID",n||gx.fn.currentGridRowImpl(84),gx.O.A21articuloscambsid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A21articuloscambsid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ARTICULOSCAMBSID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[89]={lvl:2,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ALAMCENID",gxz:"Z154alamcenid",gxold:"O154alamcenid",gxvar:"A154alamcenid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A154alamcenid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z154alamcenid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ALAMCENID",n||gx.fn.currentGridRowImpl(84),gx.O.A154alamcenid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A154alamcenid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ALAMCENID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[90]={lvl:2,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSNOETIQUETA",gxz:"Z155articulosnoetiqueta",gxold:"O155articulosnoetiqueta",gxvar:"A155articulosnoetiqueta",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A155articulosnoetiqueta=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z155articulosnoetiqueta=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ARTICULOSNOETIQUETA",n||gx.fn.currentGridRowImpl(84),gx.O.A155articulosnoetiqueta,0)},c2v:function(){this.val()!==undefined&&(gx.O.A155articulosnoetiqueta=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ARTICULOSNOETIQUETA",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[91]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"TIPOBIENID",gxz:"Z23tipobienid",gxold:"O23tipobienid",gxvar:"A23tipobienid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A23tipobienid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z23tipobienid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("TIPOBIENID",n||gx.fn.currentGridRowImpl(84),gx.O.A23tipobienid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A23tipobienid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("TIPOBIENID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[92]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ENTIDAFEDERATIVAID",gxz:"Z7entidafederativaid",gxold:"O7entidafederativaid",gxvar:"A7entidafederativaid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A7entidafederativaid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z7entidafederativaid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ENTIDAFEDERATIVAID",n||gx.fn.currentGridRowImpl(84),gx.O.A7entidafederativaid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A7entidafederativaid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ENTIDAFEDERATIVAID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[93]={fld:"",grid:0};n[94]={fld:"",grid:0};this.AV6calmacenid=0;this.ZV6calmacenid=0;this.OV6calmacenid=0;this.AV7carticulosproductoid=0;this.ZV7carticulosproductoid=0;this.OV7carticulosproductoid=0;this.AV8carticuloscambsid=0;this.ZV8carticuloscambsid=0;this.OV8carticuloscambsid=0;this.AV9calamcenid=0;this.ZV9calamcenid=0;this.OV9calamcenid=0;this.AV10carticulosnoetiqueta=0;this.ZV10carticulosnoetiqueta=0;this.OV10carticulosnoetiqueta=0;this.AV11ctipobienid=0;this.ZV11ctipobienid=0;this.OV11ctipobienid=0;this.AV12centidafederativaid=0;this.ZV12centidafederativaid=0;this.OV12centidafederativaid=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z19almacenid=0;this.O19almacenid=0;this.Z20articulosproductoid=0;this.O20articulosproductoid=0;this.Z21articuloscambsid=0;this.O21articuloscambsid=0;this.Z154alamcenid=0;this.O154alamcenid=0;this.Z155articulosnoetiqueta=0;this.O155articulosnoetiqueta=0;this.Z23tipobienid=0;this.O23tipobienid=0;this.Z7entidafederativaid=0;this.O7entidafederativaid=0;this.AV6calmacenid=0;this.AV7carticulosproductoid=0;this.AV8carticuloscambsid=0;this.AV9calamcenid=0;this.AV10carticulosnoetiqueta=0;this.AV11ctipobienid=0;this.AV12centidafederativaid=0;this.AV13palmacenid=0;this.AV14particulosproductoid=0;this.AV15particuloscambsid=0;this.AV5LinkSelection="";this.A19almacenid=0;this.A20articulosproductoid=0;this.A21articuloscambsid=0;this.A154alamcenid=0;this.A155articulosnoetiqueta=0;this.A23tipobienid=0;this.A7entidafederativaid=0;this.Events={e21212_client:["ENTER",!0],e22211_client:["CANCEL",!0],e18211_client:["'TOGGLE'",!1],e11211_client:["LBLALMACENIDFILTER.CLICK",!1],e12211_client:["LBLARTICULOSPRODUCTOIDFILTER.CLICK",!1],e13211_client:["LBLARTICULOSCAMBSIDFILTER.CLICK",!1],e14211_client:["LBLALAMCENIDFILTER.CLICK",!1],e15211_client:["LBLARTICULOSNOETIQUETAFILTER.CLICK",!1],e16211_client:["LBLTIPOBIENIDFILTER.CLICK",!1],e17211_client:["LBLENTIDAFEDERATIVAIDFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6calmacenid",fld:"vCALMACENID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7carticulosproductoid",fld:"vCARTICULOSPRODUCTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8carticuloscambsid",fld:"vCARTICULOSCAMBSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV9calamcenid",fld:"vCALAMCENID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10carticulosnoetiqueta",fld:"vCARTICULOSNOETIQUETA",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11ctipobienid",fld:"vCTIPOBIENID",pic:"ZZZZZZZZ9",nv:0},{av:"AV12centidafederativaid",fld:"vCENTIDAFEDERATIVAID",pic:"ZZZZZZZZ9",nv:0}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLALMACENIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ALMACENIDFILTERCONTAINER","Class")',ctrl:"ALMACENIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ALMACENIDFILTERCONTAINER","Class")',ctrl:"ALMACENIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCALMACENID","Visible")',ctrl:"vCALMACENID",prop:"Visible"}]];this.EvtParms["LBLARTICULOSPRODUCTOIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ARTICULOSPRODUCTOIDFILTERCONTAINER","Class")',ctrl:"ARTICULOSPRODUCTOIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ARTICULOSPRODUCTOIDFILTERCONTAINER","Class")',ctrl:"ARTICULOSPRODUCTOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCARTICULOSPRODUCTOID","Visible")',ctrl:"vCARTICULOSPRODUCTOID",prop:"Visible"}]];this.EvtParms["LBLARTICULOSCAMBSIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ARTICULOSCAMBSIDFILTERCONTAINER","Class")',ctrl:"ARTICULOSCAMBSIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ARTICULOSCAMBSIDFILTERCONTAINER","Class")',ctrl:"ARTICULOSCAMBSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCARTICULOSCAMBSID","Visible")',ctrl:"vCARTICULOSCAMBSID",prop:"Visible"}]];this.EvtParms["LBLALAMCENIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ALAMCENIDFILTERCONTAINER","Class")',ctrl:"ALAMCENIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ALAMCENIDFILTERCONTAINER","Class")',ctrl:"ALAMCENIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCALAMCENID","Visible")',ctrl:"vCALAMCENID",prop:"Visible"}]];this.EvtParms["LBLARTICULOSNOETIQUETAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ARTICULOSNOETIQUETAFILTERCONTAINER","Class")',ctrl:"ARTICULOSNOETIQUETAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ARTICULOSNOETIQUETAFILTERCONTAINER","Class")',ctrl:"ARTICULOSNOETIQUETAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCARTICULOSNOETIQUETA","Visible")',ctrl:"vCARTICULOSNOETIQUETA",prop:"Visible"}]];this.EvtParms["LBLTIPOBIENIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("TIPOBIENIDFILTERCONTAINER","Class")',ctrl:"TIPOBIENIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("TIPOBIENIDFILTERCONTAINER","Class")',ctrl:"TIPOBIENIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTIPOBIENID","Visible")',ctrl:"vCTIPOBIENID",prop:"Visible"}]];this.EvtParms["LBLENTIDAFEDERATIVAIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ENTIDAFEDERATIVAIDFILTERCONTAINER","Class")',ctrl:"ENTIDAFEDERATIVAIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ENTIDAFEDERATIVAIDFILTERCONTAINER","Class")',ctrl:"ENTIDAFEDERATIVAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCENTIDAFEDERATIVAID","Visible")',ctrl:"vCENTIDAFEDERATIVAID",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A19almacenid",fld:"ALMACENID",pic:"ZZZZZZZZZZZZZZZZZ9",hsh:!0,nv:0},{av:"A20articulosproductoid",fld:"ARTICULOSPRODUCTOID",pic:"ZZZZZZZZ9",hsh:!0,nv:0},{av:"A21articuloscambsid",fld:"ARTICULOSCAMBSID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV13palmacenid",fld:"vPALMACENID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV14particulosproductoid",fld:"vPARTICULOSPRODUCTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV15particuloscambsid",fld:"vPARTICULOSCAMBSID",pic:"ZZZZZZZZ9",nv:0}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6calmacenid",fld:"vCALMACENID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7carticulosproductoid",fld:"vCARTICULOSPRODUCTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8carticuloscambsid",fld:"vCARTICULOSCAMBSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV9calamcenid",fld:"vCALAMCENID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10carticulosnoetiqueta",fld:"vCARTICULOSNOETIQUETA",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11ctipobienid",fld:"vCTIPOBIENID",pic:"ZZZZZZZZ9",nv:0},{av:"AV12centidafederativaid",fld:"vCENTIDAFEDERATIVAID",pic:"ZZZZZZZZ9",nv:0}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6calmacenid",fld:"vCALMACENID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7carticulosproductoid",fld:"vCARTICULOSPRODUCTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8carticuloscambsid",fld:"vCARTICULOSCAMBSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV9calamcenid",fld:"vCALAMCENID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10carticulosnoetiqueta",fld:"vCARTICULOSNOETIQUETA",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11ctipobienid",fld:"vCTIPOBIENID",pic:"ZZZZZZZZ9",nv:0},{av:"AV12centidafederativaid",fld:"vCENTIDAFEDERATIVAID",pic:"ZZZZZZZZ9",nv:0}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6calmacenid",fld:"vCALMACENID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7carticulosproductoid",fld:"vCARTICULOSPRODUCTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8carticuloscambsid",fld:"vCARTICULOSCAMBSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV9calamcenid",fld:"vCALAMCENID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10carticulosnoetiqueta",fld:"vCARTICULOSNOETIQUETA",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11ctipobienid",fld:"vCTIPOBIENID",pic:"ZZZZZZZZ9",nv:0},{av:"AV12centidafederativaid",fld:"vCENTIDAFEDERATIVAID",pic:"ZZZZZZZZ9",nv:0}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6calmacenid",fld:"vCALMACENID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7carticulosproductoid",fld:"vCARTICULOSPRODUCTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8carticuloscambsid",fld:"vCARTICULOSCAMBSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV9calamcenid",fld:"vCALAMCENID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10carticulosnoetiqueta",fld:"vCARTICULOSNOETIQUETA",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11ctipobienid",fld:"vCTIPOBIENID",pic:"ZZZZZZZZ9",nv:0},{av:"AV12centidafederativaid",fld:"vCENTIDAFEDERATIVAID",pic:"ZZZZZZZZ9",nv:0}],[]];this.setVCMap("AV13palmacenid","vPALMACENID",0,"int");this.setVCMap("AV14particulosproductoid","vPARTICULOSPRODUCTOID",0,"int");this.setVCMap("AV15particuloscambsid","vPARTICULOSCAMBSID",0,"int");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar(this.GXValidFnc[66]);t.addRefreshingVar(this.GXValidFnc[76]);this.InitStandaloneVars()});gx.createParentObj(gx00b0)