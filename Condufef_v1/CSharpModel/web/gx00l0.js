/**@preserve  GeneXus C# 10_3_15-115824 on 2/2/2022 13:43:33.47
*/
gx.evt.autoSkip=!1;gx.define("gx00l0",!1,function(){var n,t;this.ServerClass="gx00l0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV13pstatusid=gx.fn.getIntegerValue("vPSTATUSID",".")};this.e182a1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle"));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}])};this.e112a1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("STATUSIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("STATUSIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCSTATUSID","Visible",!0)):(gx.fn.setCtrlProperty("STATUSIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCSTATUSID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("STATUSIDFILTERCONTAINER","Class")',ctrl:"STATUSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSTATUSID","Visible")',ctrl:"vCSTATUSID",prop:"Visible"}])};this.e122a1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("STATUSDSCFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("STATUSDSCFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCSTATUSDSC","Visible",!0)):(gx.fn.setCtrlProperty("STATUSDSCFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCSTATUSDSC","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("STATUSDSCFILTERCONTAINER","Class")',ctrl:"STATUSDSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSTATUSDSC","Visible")',ctrl:"vCSTATUSDSC",prop:"Visible"}])};this.e132a1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("STATUSUSOTABLAFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("STATUSUSOTABLAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCSTATUSUSOTABLA","Visible",!0)):(gx.fn.setCtrlProperty("STATUSUSOTABLAFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCSTATUSUSOTABLA","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("STATUSUSOTABLAFILTERCONTAINER","Class")',ctrl:"STATUSUSOTABLAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSTATUSUSOTABLA","Visible")',ctrl:"vCSTATUSUSOTABLA",prop:"Visible"}])};this.e142a1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("STATUSDESCFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("STATUSDESCFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCSTATUSDESC","Visible",!0)):(gx.fn.setCtrlProperty("STATUSDESCFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCSTATUSDESC","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("STATUSDESCFILTERCONTAINER","Class")',ctrl:"STATUSDESCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSTATUSDESC","Visible")',ctrl:"vCSTATUSDESC",prop:"Visible"}])};this.e152a1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("STATUSUSUARIOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("STATUSUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCSTATUSUSUARIO","Visible",!0)):(gx.fn.setCtrlProperty("STATUSUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCSTATUSUSUARIO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("STATUSUSUARIOFILTERCONTAINER","Class")',ctrl:"STATUSUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSTATUSUSUARIO","Visible")',ctrl:"vCSTATUSUSUARIO",prop:"Visible"}])};this.e162a1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("STATUSFECREGFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("STATUSFECREGFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("STATUSFECREGFILTERCONTAINER","Class","AdvancedContainerItem");this.refreshOutputs([{av:'gx.fn.getCtrlProperty("STATUSFECREGFILTERCONTAINER","Class")',ctrl:"STATUSFECREGFILTERCONTAINER",prop:"Class"}])};this.e172a1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("STATUSFECULTACTFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("STATUSFECULTACTFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("STATUSFECULTACTFILTERCONTAINER","Class","AdvancedContainerItem");this.refreshOutputs([{av:'gx.fn.getCtrlProperty("STATUSFECULTACTFILTERCONTAINER","Class")',ctrl:"STATUSFECULTACTFILTERCONTAINER",prop:"Class"}])};this.e212a2_client=function(){this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e222a1_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,82,83,85,86,87,88,89,90,91];this.GXLastCtrlId=91;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",84,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00l0",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",85,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(1,86,"STATUSID","statusid","","statusid","int",0,"px",9,9,"right",null,[],1,"statusid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(73,87,"STATUSDSC","statusdsc","","statusdsc","svchar",0,"px",50,50,"left",null,[],73,"statusdsc",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(74,88,"STATUSUSOTABLA","statususotabla","","statususotabla","svchar",0,"px",50,50,"left",null,[],74,"statususotabla",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(76,89,"STATUSUSUARIO","statususuario","","statususuario","svchar",0,"px",15,15,"left",null,[],76,"statususuario",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.setGrid(t);n[2]={fld:"",grid:0};n[3]={fld:"MAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"ADVANCEDCONTAINER",grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"STATUSIDFILTERCONTAINER",grid:0};n[10]={fld:"",grid:0};n[11]={fld:"",grid:0};n[12]={fld:"LBLSTATUSIDFILTER",format:1,grid:0};n[13]={fld:"",grid:0};n[14]={fld:"",grid:0};n[15]={fld:"",grid:0};n[16]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCSTATUSID",gxz:"ZV6cstatusid",gxold:"OV6cstatusid",gxvar:"AV6cstatusid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cstatusid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cstatusid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCSTATUSID",gx.O.AV6cstatusid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cstatusid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCSTATUSID",".")},nac:gx.falseFn};n[17]={fld:"",grid:0};n[18]={fld:"",grid:0};n[19]={fld:"STATUSDSCFILTERCONTAINER",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={fld:"LBLSTATUSDSCFILTER",format:1,grid:0};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCSTATUSDSC",gxz:"ZV7cstatusdsc",gxold:"OV7cstatusdsc",gxvar:"AV7cstatusdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cstatusdsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cstatusdsc=n)},v2c:function(){gx.fn.setControlValue("vCSTATUSDSC",gx.O.AV7cstatusdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cstatusdsc=this.val())},val:function(){return gx.fn.getControlValue("vCSTATUSDSC")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"STATUSUSOTABLAFILTERCONTAINER",grid:0};n[30]={fld:"",grid:0};n[31]={fld:"",grid:0};n[32]={fld:"LBLSTATUSUSOTABLAFILTER",format:1,grid:0};n[33]={fld:"",grid:0};n[34]={fld:"",grid:0};n[35]={fld:"",grid:0};n[36]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCSTATUSUSOTABLA",gxz:"ZV8cstatususotabla",gxold:"OV8cstatususotabla",gxvar:"AV8cstatususotabla",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cstatususotabla=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cstatususotabla=n)},v2c:function(){gx.fn.setControlValue("vCSTATUSUSOTABLA",gx.O.AV8cstatususotabla,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cstatususotabla=this.val())},val:function(){return gx.fn.getControlValue("vCSTATUSUSOTABLA")},nac:gx.falseFn};n[37]={fld:"",grid:0};n[38]={fld:"",grid:0};n[39]={fld:"STATUSDESCFILTERCONTAINER",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={fld:"LBLSTATUSDESCFILTER",format:1,grid:0};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCSTATUSDESC",gxz:"ZV9cstatusdesc",gxold:"OV9cstatusdesc",gxvar:"AV9cstatusdesc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9cstatusdesc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV9cstatusdesc=n)},v2c:function(){gx.fn.setControlValue("vCSTATUSDESC",gx.O.AV9cstatusdesc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9cstatusdesc=this.val())},val:function(){return gx.fn.getControlValue("vCSTATUSDESC")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"STATUSUSUARIOFILTERCONTAINER",grid:0};n[50]={fld:"",grid:0};n[51]={fld:"",grid:0};n[52]={fld:"LBLSTATUSUSUARIOFILTER",format:1,grid:0};n[53]={fld:"",grid:0};n[54]={fld:"",grid:0};n[55]={fld:"",grid:0};n[56]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCSTATUSUSUARIO",gxz:"ZV10cstatususuario",gxold:"OV10cstatususuario",gxvar:"AV10cstatususuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10cstatususuario=n)},v2z:function(n){n!==undefined&&(gx.O.ZV10cstatususuario=n)},v2c:function(){gx.fn.setControlValue("vCSTATUSUSUARIO",gx.O.AV10cstatususuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10cstatususuario=this.val())},val:function(){return gx.fn.getControlValue("vCSTATUSUSUARIO")},nac:gx.falseFn};n[57]={fld:"",grid:0};n[58]={fld:"",grid:0};n[59]={fld:"STATUSFECREGFILTERCONTAINER",grid:0};n[60]={fld:"",grid:0};n[61]={fld:"",grid:0};n[62]={fld:"LBLSTATUSFECREGFILTER",format:1,grid:0};n[63]={fld:"",grid:0};n[64]={fld:"",grid:0};n[65]={fld:"",grid:0};n[66]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCSTATUSFECREG",gxz:"ZV11cstatusfecreg",gxold:"OV11cstatusfecreg",gxvar:"AV11cstatusfecreg",dp:{f:-1,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11cstatusfecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV11cstatusfecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCSTATUSFECREG",gx.O.AV11cstatusfecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11cstatusfecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vCSTATUSFECREG")},nac:gx.falseFn};n[67]={fld:"",grid:0};n[68]={fld:"",grid:0};n[69]={fld:"STATUSFECULTACTFILTERCONTAINER",grid:0};n[70]={fld:"",grid:0};n[71]={fld:"",grid:0};n[72]={fld:"LBLSTATUSFECULTACTFILTER",format:1,grid:0};n[73]={fld:"",grid:0};n[74]={fld:"",grid:0};n[75]={fld:"",grid:0};n[76]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCSTATUSFECULTACT",gxz:"ZV12cstatusfecultact",gxold:"OV12cstatusfecultact",gxvar:"AV12cstatusfecultact",dp:{f:-1,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV12cstatusfecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV12cstatusfecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCSTATUSFECULTACT",gx.O.AV12cstatusfecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV12cstatusfecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vCSTATUSFECULTACT")},nac:gx.falseFn};n[77]={fld:"",grid:0};n[78]={fld:"GRIDTABLE",grid:0};n[79]={fld:"",grid:0};n[80]={fld:"",grid:0};n[82]={fld:"",grid:0};n[83]={fld:"",grid:0};n[85]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84),gx.O.AV5LinkSelection,gx.O.AV17Linkselection_GXI)},c2v:function(){gx.O.AV17Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(84))},gxvar_GXI:"AV17Linkselection_GXI",nac:gx.falseFn};n[86]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"STATUSID",gxz:"Z1statusid",gxold:"O1statusid",gxvar:"A1statusid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A1statusid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1statusid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("STATUSID",n||gx.fn.currentGridRowImpl(84),gx.O.A1statusid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A1statusid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("STATUSID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[87]={lvl:2,type:"svchar",len:50,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"STATUSDSC",gxz:"Z73statusdsc",gxold:"O73statusdsc",gxvar:"A73statusdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A73statusdsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z73statusdsc=n)},v2c:function(n){gx.fn.setGridControlValue("STATUSDSC",n||gx.fn.currentGridRowImpl(84),gx.O.A73statusdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A73statusdsc=this.val())},val:function(n){return gx.fn.getGridControlValue("STATUSDSC",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[88]={lvl:2,type:"svchar",len:50,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"STATUSUSOTABLA",gxz:"Z74statususotabla",gxold:"O74statususotabla",gxvar:"A74statususotabla",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A74statususotabla=n)},v2z:function(n){n!==undefined&&(gx.O.Z74statususotabla=n)},v2c:function(n){gx.fn.setGridControlValue("STATUSUSOTABLA",n||gx.fn.currentGridRowImpl(84),gx.O.A74statususotabla,0)},c2v:function(){this.val()!==undefined&&(gx.O.A74statususotabla=this.val())},val:function(n){return gx.fn.getGridControlValue("STATUSUSOTABLA",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[89]={lvl:2,type:"svchar",len:15,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"STATUSUSUARIO",gxz:"Z76statususuario",gxold:"O76statususuario",gxvar:"A76statususuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A76statususuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z76statususuario=n)},v2c:function(n){gx.fn.setGridControlValue("STATUSUSUARIO",n||gx.fn.currentGridRowImpl(84),gx.O.A76statususuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A76statususuario=this.val())},val:function(n){return gx.fn.getGridControlValue("STATUSUSUARIO",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[90]={fld:"",grid:0};n[91]={fld:"",grid:0};this.AV6cstatusid=0;this.ZV6cstatusid=0;this.OV6cstatusid=0;this.AV7cstatusdsc="";this.ZV7cstatusdsc="";this.OV7cstatusdsc="";this.AV8cstatususotabla="";this.ZV8cstatususotabla="";this.OV8cstatususotabla="";this.AV9cstatusdesc="";this.ZV9cstatusdesc="";this.OV9cstatusdesc="";this.AV10cstatususuario="";this.ZV10cstatususuario="";this.OV10cstatususuario="";this.AV11cstatusfecreg=gx.date.nullDate();this.ZV11cstatusfecreg=gx.date.nullDate();this.OV11cstatusfecreg=gx.date.nullDate();this.AV12cstatusfecultact=gx.date.nullDate();this.ZV12cstatusfecultact=gx.date.nullDate();this.OV12cstatusfecultact=gx.date.nullDate();this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z1statusid=0;this.O1statusid=0;this.Z73statusdsc="";this.O73statusdsc="";this.Z74statususotabla="";this.O74statususotabla="";this.Z76statususuario="";this.O76statususuario="";this.AV6cstatusid=0;this.AV7cstatusdsc="";this.AV8cstatususotabla="";this.AV9cstatusdesc="";this.AV10cstatususuario="";this.AV11cstatusfecreg=gx.date.nullDate();this.AV12cstatusfecultact=gx.date.nullDate();this.AV13pstatusid=0;this.A78statusfecultact=gx.date.nullDate();this.A77statusfecreg=gx.date.nullDate();this.A75statusdesc="";this.AV5LinkSelection="";this.A1statusid=0;this.A73statusdsc="";this.A74statususotabla="";this.A76statususuario="";this.Events={e212a2_client:["ENTER",!0],e222a1_client:["CANCEL",!0],e182a1_client:["'TOGGLE'",!1],e112a1_client:["LBLSTATUSIDFILTER.CLICK",!1],e122a1_client:["LBLSTATUSDSCFILTER.CLICK",!1],e132a1_client:["LBLSTATUSUSOTABLAFILTER.CLICK",!1],e142a1_client:["LBLSTATUSDESCFILTER.CLICK",!1],e152a1_client:["LBLSTATUSUSUARIOFILTER.CLICK",!1],e162a1_client:["LBLSTATUSFECREGFILTER.CLICK",!1],e172a1_client:["LBLSTATUSFECULTACTFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cstatusid",fld:"vCSTATUSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cstatusdsc",fld:"vCSTATUSDSC",pic:"",nv:""},{av:"AV8cstatususotabla",fld:"vCSTATUSUSOTABLA",pic:"",nv:""},{av:"AV9cstatusdesc",fld:"vCSTATUSDESC",pic:"",nv:""},{av:"AV10cstatususuario",fld:"vCSTATUSUSUARIO",pic:"",nv:""},{av:"AV11cstatusfecreg",fld:"vCSTATUSFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV12cstatusfecultact",fld:"vCSTATUSFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLSTATUSIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("STATUSIDFILTERCONTAINER","Class")',ctrl:"STATUSIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("STATUSIDFILTERCONTAINER","Class")',ctrl:"STATUSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSTATUSID","Visible")',ctrl:"vCSTATUSID",prop:"Visible"}]];this.EvtParms["LBLSTATUSDSCFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("STATUSDSCFILTERCONTAINER","Class")',ctrl:"STATUSDSCFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("STATUSDSCFILTERCONTAINER","Class")',ctrl:"STATUSDSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSTATUSDSC","Visible")',ctrl:"vCSTATUSDSC",prop:"Visible"}]];this.EvtParms["LBLSTATUSUSOTABLAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("STATUSUSOTABLAFILTERCONTAINER","Class")',ctrl:"STATUSUSOTABLAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("STATUSUSOTABLAFILTERCONTAINER","Class")',ctrl:"STATUSUSOTABLAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSTATUSUSOTABLA","Visible")',ctrl:"vCSTATUSUSOTABLA",prop:"Visible"}]];this.EvtParms["LBLSTATUSDESCFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("STATUSDESCFILTERCONTAINER","Class")',ctrl:"STATUSDESCFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("STATUSDESCFILTERCONTAINER","Class")',ctrl:"STATUSDESCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSTATUSDESC","Visible")',ctrl:"vCSTATUSDESC",prop:"Visible"}]];this.EvtParms["LBLSTATUSUSUARIOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("STATUSUSUARIOFILTERCONTAINER","Class")',ctrl:"STATUSUSUARIOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("STATUSUSUARIOFILTERCONTAINER","Class")',ctrl:"STATUSUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSTATUSUSUARIO","Visible")',ctrl:"vCSTATUSUSUARIO",prop:"Visible"}]];this.EvtParms["LBLSTATUSFECREGFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("STATUSFECREGFILTERCONTAINER","Class")',ctrl:"STATUSFECREGFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("STATUSFECREGFILTERCONTAINER","Class")',ctrl:"STATUSFECREGFILTERCONTAINER",prop:"Class"}]];this.EvtParms["LBLSTATUSFECULTACTFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("STATUSFECULTACTFILTERCONTAINER","Class")',ctrl:"STATUSFECULTACTFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("STATUSFECULTACTFILTERCONTAINER","Class")',ctrl:"STATUSFECULTACTFILTERCONTAINER",prop:"Class"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A1statusid",fld:"STATUSID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV13pstatusid",fld:"vPSTATUSID",pic:"ZZZZZZZZ9",nv:0}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cstatusid",fld:"vCSTATUSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cstatusdsc",fld:"vCSTATUSDSC",pic:"",nv:""},{av:"AV8cstatususotabla",fld:"vCSTATUSUSOTABLA",pic:"",nv:""},{av:"AV9cstatusdesc",fld:"vCSTATUSDESC",pic:"",nv:""},{av:"AV10cstatususuario",fld:"vCSTATUSUSUARIO",pic:"",nv:""},{av:"AV11cstatusfecreg",fld:"vCSTATUSFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV12cstatusfecultact",fld:"vCSTATUSFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cstatusid",fld:"vCSTATUSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cstatusdsc",fld:"vCSTATUSDSC",pic:"",nv:""},{av:"AV8cstatususotabla",fld:"vCSTATUSUSOTABLA",pic:"",nv:""},{av:"AV9cstatusdesc",fld:"vCSTATUSDESC",pic:"",nv:""},{av:"AV10cstatususuario",fld:"vCSTATUSUSUARIO",pic:"",nv:""},{av:"AV11cstatusfecreg",fld:"vCSTATUSFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV12cstatusfecultact",fld:"vCSTATUSFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cstatusid",fld:"vCSTATUSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cstatusdsc",fld:"vCSTATUSDSC",pic:"",nv:""},{av:"AV8cstatususotabla",fld:"vCSTATUSUSOTABLA",pic:"",nv:""},{av:"AV9cstatusdesc",fld:"vCSTATUSDESC",pic:"",nv:""},{av:"AV10cstatususuario",fld:"vCSTATUSUSUARIO",pic:"",nv:""},{av:"AV11cstatusfecreg",fld:"vCSTATUSFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV12cstatusfecultact",fld:"vCSTATUSFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cstatusid",fld:"vCSTATUSID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cstatusdsc",fld:"vCSTATUSDSC",pic:"",nv:""},{av:"AV8cstatususotabla",fld:"vCSTATUSUSOTABLA",pic:"",nv:""},{av:"AV9cstatusdesc",fld:"vCSTATUSDESC",pic:"",nv:""},{av:"AV10cstatususuario",fld:"vCSTATUSUSUARIO",pic:"",nv:""},{av:"AV11cstatusfecreg",fld:"vCSTATUSFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV12cstatusfecultact",fld:"vCSTATUSFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.setVCMap("AV13pstatusid","vPSTATUSID",0,"int");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar(this.GXValidFnc[66]);t.addRefreshingVar(this.GXValidFnc[76]);this.InitStandaloneVars()});gx.createParentObj(gx00l0)