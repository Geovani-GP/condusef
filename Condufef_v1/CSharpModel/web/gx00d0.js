/**@preserve  GeneXus C# 10_3_15-115824 on 1/22/2022 13:28:12.79
*/
gx.evt.autoSkip=!1;gx.define("gx00d0",!1,function(){var n,t;this.ServerClass="gx00d0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV13particulosmovid=gx.fn.getIntegerValue("vPARTICULOSMOVID",".");this.AV14particulosmovproductoid=gx.fn.getIntegerValue("vPARTICULOSMOVPRODUCTOID",".");this.AV15particulosmovcambsid=gx.fn.getControlValue("vPARTICULOSMOVCAMBSID");this.AV16particulosmovarticuloid=gx.fn.getIntegerValue("vPARTICULOSMOVARTICULOID",".")};this.e180n1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle"));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}])};this.e110n1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ARTICULOSMOVIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ARTICULOSMOVIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCARTICULOSMOVID","Visible",!0)):(gx.fn.setCtrlProperty("ARTICULOSMOVIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCARTICULOSMOVID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ARTICULOSMOVIDFILTERCONTAINER","Class")',ctrl:"ARTICULOSMOVIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCARTICULOSMOVID","Visible")',ctrl:"vCARTICULOSMOVID",prop:"Visible"}])};this.e120n1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ARTICULOSMOVPRODUCTOIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ARTICULOSMOVPRODUCTOIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCARTICULOSMOVPRODUCTOID","Visible",!0)):(gx.fn.setCtrlProperty("ARTICULOSMOVPRODUCTOIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCARTICULOSMOVPRODUCTOID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ARTICULOSMOVPRODUCTOIDFILTERCONTAINER","Class")',ctrl:"ARTICULOSMOVPRODUCTOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCARTICULOSMOVPRODUCTOID","Visible")',ctrl:"vCARTICULOSMOVPRODUCTOID",prop:"Visible"}])};this.e130n1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ARTICULOSMOVCAMBSIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ARTICULOSMOVCAMBSIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCARTICULOSMOVCAMBSID","Visible",!0)):(gx.fn.setCtrlProperty("ARTICULOSMOVCAMBSIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCARTICULOSMOVCAMBSID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ARTICULOSMOVCAMBSIDFILTERCONTAINER","Class")',ctrl:"ARTICULOSMOVCAMBSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCARTICULOSMOVCAMBSID","Visible")',ctrl:"vCARTICULOSMOVCAMBSID",prop:"Visible"}])};this.e140n1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ARTICULOSMOVARTICULOIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ARTICULOSMOVARTICULOIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCARTICULOSMOVARTICULOID","Visible",!0)):(gx.fn.setCtrlProperty("ARTICULOSMOVARTICULOIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCARTICULOSMOVARTICULOID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ARTICULOSMOVARTICULOIDFILTERCONTAINER","Class")',ctrl:"ARTICULOSMOVARTICULOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCARTICULOSMOVARTICULOID","Visible")',ctrl:"vCARTICULOSMOVARTICULOID",prop:"Visible"}])};this.e150n1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ARTICULOSMOVDEPOSITARIOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ARTICULOSMOVDEPOSITARIOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCARTICULOSMOVDEPOSITARIO","Visible",!0)):(gx.fn.setCtrlProperty("ARTICULOSMOVDEPOSITARIOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCARTICULOSMOVDEPOSITARIO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ARTICULOSMOVDEPOSITARIOFILTERCONTAINER","Class")',ctrl:"ARTICULOSMOVDEPOSITARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCARTICULOSMOVDEPOSITARIO","Visible")',ctrl:"vCARTICULOSMOVDEPOSITARIO",prop:"Visible"}])};this.e160n1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ARTICULOSMOVFECHAMOVFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("ARTICULOSMOVFECHAMOVFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("ARTICULOSMOVFECHAMOVFILTERCONTAINER","Class","AdvancedContainerItem");this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ARTICULOSMOVFECHAMOVFILTERCONTAINER","Class")',ctrl:"ARTICULOSMOVFECHAMOVFILTERCONTAINER",prop:"Class"}])};this.e170n1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ARTICULOSMOVSTATUSFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ARTICULOSMOVSTATUSFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCARTICULOSMOVSTATUS","Visible",!0)):(gx.fn.setCtrlProperty("ARTICULOSMOVSTATUSFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCARTICULOSMOVSTATUS","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ARTICULOSMOVSTATUSFILTERCONTAINER","Class")',ctrl:"ARTICULOSMOVSTATUSFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCARTICULOSMOVSTATUS","Visible")',ctrl:"vCARTICULOSMOVSTATUS",prop:"Visible"}])};this.e210n2_client=function(){this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e220n1_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,82,83,85,86,87,88,89,90,91,92,93];this.GXLastCtrlId=93;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",84,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00d0",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",85,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(3,86,"ARTICULOSMOVID","articulosmovid","","articulosmovid","int",0,"px",9,9,"right",null,[],3,"articulosmovid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(4,87,"ARTICULOSMOVPRODUCTOID","productoid","","articulosmovproductoid","int",0,"px",9,9,"right",null,[],4,"articulosmovproductoid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(5,88,"ARTICULOSMOVCAMBSID","cambsid","","articulosmovcambsid","svchar",0,"px",3,3,"left",null,[],5,"articulosmovcambsid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(6,89,"ARTICULOSMOVARTICULOID","articulosmovarticuloid","","articulosmovarticuloid","int",0,"px",18,18,"right",null,[],6,"articulosmovarticuloid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(39,90,"ARTICULOSMOVDEPOSITARIO","articulosmovdepositario","","articulosmovdepositario","int",0,"px",18,18,"right",null,[],39,"articulosmovdepositario",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(40,91,"ARTICULOSMOVFECHAMOV","articulosmovfechamov","","articulosmovfechamov","dtime",0,"px",19,19,"right",null,[],40,"articulosmovfechamov",!0,8,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.setGrid(t);n[2]={fld:"",grid:0};n[3]={fld:"MAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"ADVANCEDCONTAINER",grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"ARTICULOSMOVIDFILTERCONTAINER",grid:0};n[10]={fld:"",grid:0};n[11]={fld:"",grid:0};n[12]={fld:"LBLARTICULOSMOVIDFILTER",format:1,grid:0};n[13]={fld:"",grid:0};n[14]={fld:"",grid:0};n[15]={fld:"",grid:0};n[16]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCARTICULOSMOVID",gxz:"ZV6carticulosmovid",gxold:"OV6carticulosmovid",gxvar:"AV6carticulosmovid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6carticulosmovid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6carticulosmovid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCARTICULOSMOVID",gx.O.AV6carticulosmovid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6carticulosmovid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCARTICULOSMOVID",".")},nac:gx.falseFn};n[17]={fld:"",grid:0};n[18]={fld:"",grid:0};n[19]={fld:"ARTICULOSMOVPRODUCTOIDFILTERCONTAINER",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={fld:"LBLARTICULOSMOVPRODUCTOIDFILTER",format:1,grid:0};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCARTICULOSMOVPRODUCTOID",gxz:"ZV7carticulosmovproductoid",gxold:"OV7carticulosmovproductoid",gxvar:"AV7carticulosmovproductoid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7carticulosmovproductoid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7carticulosmovproductoid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCARTICULOSMOVPRODUCTOID",gx.O.AV7carticulosmovproductoid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7carticulosmovproductoid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCARTICULOSMOVPRODUCTOID",".")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"ARTICULOSMOVCAMBSIDFILTERCONTAINER",grid:0};n[30]={fld:"",grid:0};n[31]={fld:"",grid:0};n[32]={fld:"LBLARTICULOSMOVCAMBSIDFILTER",format:1,grid:0};n[33]={fld:"",grid:0};n[34]={fld:"",grid:0};n[35]={fld:"",grid:0};n[36]={lvl:0,type:"svchar",len:3,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCARTICULOSMOVCAMBSID",gxz:"ZV8carticulosmovcambsid",gxold:"OV8carticulosmovcambsid",gxvar:"AV8carticulosmovcambsid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8carticulosmovcambsid=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8carticulosmovcambsid=n)},v2c:function(){gx.fn.setControlValue("vCARTICULOSMOVCAMBSID",gx.O.AV8carticulosmovcambsid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8carticulosmovcambsid=this.val())},val:function(){return gx.fn.getControlValue("vCARTICULOSMOVCAMBSID")},nac:gx.falseFn};n[37]={fld:"",grid:0};n[38]={fld:"",grid:0};n[39]={fld:"ARTICULOSMOVARTICULOIDFILTERCONTAINER",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={fld:"LBLARTICULOSMOVARTICULOIDFILTER",format:1,grid:0};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCARTICULOSMOVARTICULOID",gxz:"ZV9carticulosmovarticuloid",gxold:"OV9carticulosmovarticuloid",gxvar:"AV9carticulosmovarticuloid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9carticulosmovarticuloid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV9carticulosmovarticuloid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCARTICULOSMOVARTICULOID",gx.O.AV9carticulosmovarticuloid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9carticulosmovarticuloid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCARTICULOSMOVARTICULOID",".")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"ARTICULOSMOVDEPOSITARIOFILTERCONTAINER",grid:0};n[50]={fld:"",grid:0};n[51]={fld:"",grid:0};n[52]={fld:"LBLARTICULOSMOVDEPOSITARIOFILTER",format:1,grid:0};n[53]={fld:"",grid:0};n[54]={fld:"",grid:0};n[55]={fld:"",grid:0};n[56]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCARTICULOSMOVDEPOSITARIO",gxz:"ZV10carticulosmovdepositario",gxold:"OV10carticulosmovdepositario",gxvar:"AV10carticulosmovdepositario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10carticulosmovdepositario=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV10carticulosmovdepositario=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCARTICULOSMOVDEPOSITARIO",gx.O.AV10carticulosmovdepositario,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10carticulosmovdepositario=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCARTICULOSMOVDEPOSITARIO",".")},nac:gx.falseFn};n[57]={fld:"",grid:0};n[58]={fld:"",grid:0};n[59]={fld:"ARTICULOSMOVFECHAMOVFILTERCONTAINER",grid:0};n[60]={fld:"",grid:0};n[61]={fld:"",grid:0};n[62]={fld:"LBLARTICULOSMOVFECHAMOVFILTER",format:1,grid:0};n[63]={fld:"",grid:0};n[64]={fld:"",grid:0};n[65]={fld:"",grid:0};n[66]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCARTICULOSMOVFECHAMOV",gxz:"ZV11carticulosmovfechamov",gxold:"OV11carticulosmovfechamov",gxvar:"AV11carticulosmovfechamov",dp:{f:-1,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11carticulosmovfechamov=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV11carticulosmovfechamov=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCARTICULOSMOVFECHAMOV",gx.O.AV11carticulosmovfechamov,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11carticulosmovfechamov=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vCARTICULOSMOVFECHAMOV")},nac:gx.falseFn};n[67]={fld:"",grid:0};n[68]={fld:"",grid:0};n[69]={fld:"ARTICULOSMOVSTATUSFILTERCONTAINER",grid:0};n[70]={fld:"",grid:0};n[71]={fld:"",grid:0};n[72]={fld:"LBLARTICULOSMOVSTATUSFILTER",format:1,grid:0};n[73]={fld:"",grid:0};n[74]={fld:"",grid:0};n[75]={fld:"",grid:0};n[76]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCARTICULOSMOVSTATUS",gxz:"ZV12carticulosmovstatus",gxold:"OV12carticulosmovstatus",gxvar:"AV12carticulosmovstatus",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV12carticulosmovstatus=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV12carticulosmovstatus=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCARTICULOSMOVSTATUS",gx.O.AV12carticulosmovstatus,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV12carticulosmovstatus=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCARTICULOSMOVSTATUS",".")},nac:gx.falseFn};n[77]={fld:"",grid:0};n[78]={fld:"GRIDTABLE",grid:0};n[79]={fld:"",grid:0};n[80]={fld:"",grid:0};n[82]={fld:"",grid:0};n[83]={fld:"",grid:0};n[85]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84),gx.O.AV5LinkSelection,gx.O.AV20Linkselection_GXI)},c2v:function(){gx.O.AV20Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(84))},gxvar_GXI:"AV20Linkselection_GXI",nac:gx.falseFn};n[86]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSMOVID",gxz:"Z3articulosmovid",gxold:"O3articulosmovid",gxvar:"A3articulosmovid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A3articulosmovid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z3articulosmovid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ARTICULOSMOVID",n||gx.fn.currentGridRowImpl(84),gx.O.A3articulosmovid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A3articulosmovid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ARTICULOSMOVID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[87]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSMOVPRODUCTOID",gxz:"Z4articulosmovproductoid",gxold:"O4articulosmovproductoid",gxvar:"A4articulosmovproductoid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A4articulosmovproductoid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z4articulosmovproductoid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ARTICULOSMOVPRODUCTOID",n||gx.fn.currentGridRowImpl(84),gx.O.A4articulosmovproductoid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A4articulosmovproductoid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ARTICULOSMOVPRODUCTOID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[88]={lvl:2,type:"svchar",len:3,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSMOVCAMBSID",gxz:"Z5articulosmovcambsid",gxold:"O5articulosmovcambsid",gxvar:"A5articulosmovcambsid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A5articulosmovcambsid=n)},v2z:function(n){n!==undefined&&(gx.O.Z5articulosmovcambsid=n)},v2c:function(n){gx.fn.setGridControlValue("ARTICULOSMOVCAMBSID",n||gx.fn.currentGridRowImpl(84),gx.O.A5articulosmovcambsid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A5articulosmovcambsid=this.val())},val:function(n){return gx.fn.getGridControlValue("ARTICULOSMOVCAMBSID",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[89]={lvl:2,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSMOVARTICULOID",gxz:"Z6articulosmovarticuloid",gxold:"O6articulosmovarticuloid",gxvar:"A6articulosmovarticuloid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A6articulosmovarticuloid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z6articulosmovarticuloid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ARTICULOSMOVARTICULOID",n||gx.fn.currentGridRowImpl(84),gx.O.A6articulosmovarticuloid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A6articulosmovarticuloid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ARTICULOSMOVARTICULOID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[90]={lvl:2,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSMOVDEPOSITARIO",gxz:"Z39articulosmovdepositario",gxold:"O39articulosmovdepositario",gxvar:"A39articulosmovdepositario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A39articulosmovdepositario=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z39articulosmovdepositario=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ARTICULOSMOVDEPOSITARIO",n||gx.fn.currentGridRowImpl(84),gx.O.A39articulosmovdepositario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A39articulosmovdepositario=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ARTICULOSMOVDEPOSITARIO",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[91]={lvl:2,type:"dtime",len:10,dec:8,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSMOVFECHAMOV",gxz:"Z40articulosmovfechamov",gxold:"O40articulosmovfechamov",gxvar:"A40articulosmovfechamov",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A40articulosmovfechamov=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z40articulosmovfechamov=gx.fn.toDatetimeValue(n))},v2c:function(n){gx.fn.setGridControlValue("ARTICULOSMOVFECHAMOV",n||gx.fn.currentGridRowImpl(84),gx.O.A40articulosmovfechamov,0)},c2v:function(){this.val()!==undefined&&(gx.O.A40articulosmovfechamov=gx.fn.toDatetimeValue(this.val()))},val:function(n){return gx.fn.getGridDateTimeValue("ARTICULOSMOVFECHAMOV",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[92]={fld:"",grid:0};n[93]={fld:"",grid:0};this.AV6carticulosmovid=0;this.ZV6carticulosmovid=0;this.OV6carticulosmovid=0;this.AV7carticulosmovproductoid=0;this.ZV7carticulosmovproductoid=0;this.OV7carticulosmovproductoid=0;this.AV8carticulosmovcambsid="";this.ZV8carticulosmovcambsid="";this.OV8carticulosmovcambsid="";this.AV9carticulosmovarticuloid=0;this.ZV9carticulosmovarticuloid=0;this.OV9carticulosmovarticuloid=0;this.AV10carticulosmovdepositario=0;this.ZV10carticulosmovdepositario=0;this.OV10carticulosmovdepositario=0;this.AV11carticulosmovfechamov=gx.date.nullDate();this.ZV11carticulosmovfechamov=gx.date.nullDate();this.OV11carticulosmovfechamov=gx.date.nullDate();this.AV12carticulosmovstatus=0;this.ZV12carticulosmovstatus=0;this.OV12carticulosmovstatus=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z3articulosmovid=0;this.O3articulosmovid=0;this.Z4articulosmovproductoid=0;this.O4articulosmovproductoid=0;this.Z5articulosmovcambsid="";this.O5articulosmovcambsid="";this.Z6articulosmovarticuloid=0;this.O6articulosmovarticuloid=0;this.Z39articulosmovdepositario=0;this.O39articulosmovdepositario=0;this.Z40articulosmovfechamov=gx.date.nullDate();this.O40articulosmovfechamov=gx.date.nullDate();this.AV6carticulosmovid=0;this.AV7carticulosmovproductoid=0;this.AV8carticulosmovcambsid="";this.AV9carticulosmovarticuloid=0;this.AV10carticulosmovdepositario=0;this.AV11carticulosmovfechamov=gx.date.nullDate();this.AV12carticulosmovstatus=0;this.AV13particulosmovid=0;this.AV14particulosmovproductoid=0;this.AV15particulosmovcambsid="";this.AV16particulosmovarticuloid=0;this.A41articulosmovstatus=0;this.AV5LinkSelection="";this.A3articulosmovid=0;this.A4articulosmovproductoid=0;this.A5articulosmovcambsid="";this.A6articulosmovarticuloid=0;this.A39articulosmovdepositario=0;this.A40articulosmovfechamov=gx.date.nullDate();this.Events={e210n2_client:["ENTER",!0],e220n1_client:["CANCEL",!0],e180n1_client:["'TOGGLE'",!1],e110n1_client:["LBLARTICULOSMOVIDFILTER.CLICK",!1],e120n1_client:["LBLARTICULOSMOVPRODUCTOIDFILTER.CLICK",!1],e130n1_client:["LBLARTICULOSMOVCAMBSIDFILTER.CLICK",!1],e140n1_client:["LBLARTICULOSMOVARTICULOIDFILTER.CLICK",!1],e150n1_client:["LBLARTICULOSMOVDEPOSITARIOFILTER.CLICK",!1],e160n1_client:["LBLARTICULOSMOVFECHAMOVFILTER.CLICK",!1],e170n1_client:["LBLARTICULOSMOVSTATUSFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6carticulosmovid",fld:"vCARTICULOSMOVID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7carticulosmovproductoid",fld:"vCARTICULOSMOVPRODUCTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8carticulosmovcambsid",fld:"vCARTICULOSMOVCAMBSID",pic:"",nv:""},{av:"AV9carticulosmovarticuloid",fld:"vCARTICULOSMOVARTICULOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10carticulosmovdepositario",fld:"vCARTICULOSMOVDEPOSITARIO",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11carticulosmovfechamov",fld:"vCARTICULOSMOVFECHAMOV",pic:"99/99/9999 99:99:99",nv:""},{av:"AV12carticulosmovstatus",fld:"vCARTICULOSMOVSTATUS",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLARTICULOSMOVIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ARTICULOSMOVIDFILTERCONTAINER","Class")',ctrl:"ARTICULOSMOVIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ARTICULOSMOVIDFILTERCONTAINER","Class")',ctrl:"ARTICULOSMOVIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCARTICULOSMOVID","Visible")',ctrl:"vCARTICULOSMOVID",prop:"Visible"}]];this.EvtParms["LBLARTICULOSMOVPRODUCTOIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ARTICULOSMOVPRODUCTOIDFILTERCONTAINER","Class")',ctrl:"ARTICULOSMOVPRODUCTOIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ARTICULOSMOVPRODUCTOIDFILTERCONTAINER","Class")',ctrl:"ARTICULOSMOVPRODUCTOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCARTICULOSMOVPRODUCTOID","Visible")',ctrl:"vCARTICULOSMOVPRODUCTOID",prop:"Visible"}]];this.EvtParms["LBLARTICULOSMOVCAMBSIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ARTICULOSMOVCAMBSIDFILTERCONTAINER","Class")',ctrl:"ARTICULOSMOVCAMBSIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ARTICULOSMOVCAMBSIDFILTERCONTAINER","Class")',ctrl:"ARTICULOSMOVCAMBSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCARTICULOSMOVCAMBSID","Visible")',ctrl:"vCARTICULOSMOVCAMBSID",prop:"Visible"}]];this.EvtParms["LBLARTICULOSMOVARTICULOIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ARTICULOSMOVARTICULOIDFILTERCONTAINER","Class")',ctrl:"ARTICULOSMOVARTICULOIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ARTICULOSMOVARTICULOIDFILTERCONTAINER","Class")',ctrl:"ARTICULOSMOVARTICULOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCARTICULOSMOVARTICULOID","Visible")',ctrl:"vCARTICULOSMOVARTICULOID",prop:"Visible"}]];this.EvtParms["LBLARTICULOSMOVDEPOSITARIOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ARTICULOSMOVDEPOSITARIOFILTERCONTAINER","Class")',ctrl:"ARTICULOSMOVDEPOSITARIOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ARTICULOSMOVDEPOSITARIOFILTERCONTAINER","Class")',ctrl:"ARTICULOSMOVDEPOSITARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCARTICULOSMOVDEPOSITARIO","Visible")',ctrl:"vCARTICULOSMOVDEPOSITARIO",prop:"Visible"}]];this.EvtParms["LBLARTICULOSMOVFECHAMOVFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ARTICULOSMOVFECHAMOVFILTERCONTAINER","Class")',ctrl:"ARTICULOSMOVFECHAMOVFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ARTICULOSMOVFECHAMOVFILTERCONTAINER","Class")',ctrl:"ARTICULOSMOVFECHAMOVFILTERCONTAINER",prop:"Class"}]];this.EvtParms["LBLARTICULOSMOVSTATUSFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ARTICULOSMOVSTATUSFILTERCONTAINER","Class")',ctrl:"ARTICULOSMOVSTATUSFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ARTICULOSMOVSTATUSFILTERCONTAINER","Class")',ctrl:"ARTICULOSMOVSTATUSFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCARTICULOSMOVSTATUS","Visible")',ctrl:"vCARTICULOSMOVSTATUS",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A3articulosmovid",fld:"ARTICULOSMOVID",pic:"ZZZZZZZZ9",hsh:!0,nv:0},{av:"A4articulosmovproductoid",fld:"ARTICULOSMOVPRODUCTOID",pic:"ZZZZZZZZ9",hsh:!0,nv:0},{av:"A5articulosmovcambsid",fld:"ARTICULOSMOVCAMBSID",pic:"",hsh:!0,nv:""},{av:"A6articulosmovarticuloid",fld:"ARTICULOSMOVARTICULOID",pic:"ZZZZZZZZZZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV13particulosmovid",fld:"vPARTICULOSMOVID",pic:"ZZZZZZZZ9",nv:0},{av:"AV14particulosmovproductoid",fld:"vPARTICULOSMOVPRODUCTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV15particulosmovcambsid",fld:"vPARTICULOSMOVCAMBSID",pic:"",nv:""},{av:"AV16particulosmovarticuloid",fld:"vPARTICULOSMOVARTICULOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6carticulosmovid",fld:"vCARTICULOSMOVID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7carticulosmovproductoid",fld:"vCARTICULOSMOVPRODUCTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8carticulosmovcambsid",fld:"vCARTICULOSMOVCAMBSID",pic:"",nv:""},{av:"AV9carticulosmovarticuloid",fld:"vCARTICULOSMOVARTICULOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10carticulosmovdepositario",fld:"vCARTICULOSMOVDEPOSITARIO",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11carticulosmovfechamov",fld:"vCARTICULOSMOVFECHAMOV",pic:"99/99/9999 99:99:99",nv:""},{av:"AV12carticulosmovstatus",fld:"vCARTICULOSMOVSTATUS",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6carticulosmovid",fld:"vCARTICULOSMOVID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7carticulosmovproductoid",fld:"vCARTICULOSMOVPRODUCTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8carticulosmovcambsid",fld:"vCARTICULOSMOVCAMBSID",pic:"",nv:""},{av:"AV9carticulosmovarticuloid",fld:"vCARTICULOSMOVARTICULOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10carticulosmovdepositario",fld:"vCARTICULOSMOVDEPOSITARIO",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11carticulosmovfechamov",fld:"vCARTICULOSMOVFECHAMOV",pic:"99/99/9999 99:99:99",nv:""},{av:"AV12carticulosmovstatus",fld:"vCARTICULOSMOVSTATUS",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6carticulosmovid",fld:"vCARTICULOSMOVID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7carticulosmovproductoid",fld:"vCARTICULOSMOVPRODUCTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8carticulosmovcambsid",fld:"vCARTICULOSMOVCAMBSID",pic:"",nv:""},{av:"AV9carticulosmovarticuloid",fld:"vCARTICULOSMOVARTICULOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10carticulosmovdepositario",fld:"vCARTICULOSMOVDEPOSITARIO",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11carticulosmovfechamov",fld:"vCARTICULOSMOVFECHAMOV",pic:"99/99/9999 99:99:99",nv:""},{av:"AV12carticulosmovstatus",fld:"vCARTICULOSMOVSTATUS",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6carticulosmovid",fld:"vCARTICULOSMOVID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7carticulosmovproductoid",fld:"vCARTICULOSMOVPRODUCTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV8carticulosmovcambsid",fld:"vCARTICULOSMOVCAMBSID",pic:"",nv:""},{av:"AV9carticulosmovarticuloid",fld:"vCARTICULOSMOVARTICULOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV10carticulosmovdepositario",fld:"vCARTICULOSMOVDEPOSITARIO",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV11carticulosmovfechamov",fld:"vCARTICULOSMOVFECHAMOV",pic:"99/99/9999 99:99:99",nv:""},{av:"AV12carticulosmovstatus",fld:"vCARTICULOSMOVSTATUS",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}],[]];this.setVCMap("AV13particulosmovid","vPARTICULOSMOVID",0,"int");this.setVCMap("AV14particulosmovproductoid","vPARTICULOSMOVPRODUCTOID",0,"int");this.setVCMap("AV15particulosmovcambsid","vPARTICULOSMOVCAMBSID",0,"svchar");this.setVCMap("AV16particulosmovarticuloid","vPARTICULOSMOVARTICULOID",0,"int");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar(this.GXValidFnc[66]);t.addRefreshingVar(this.GXValidFnc[76]);this.InitStandaloneVars()});gx.createParentObj(gx00d0)