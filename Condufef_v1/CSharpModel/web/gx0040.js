/**@preserve  GeneXus C# 10_3_15-115824 on 12/30/2021 22:9:19.54
*/
gx.evt.autoSkip=!1;gx.define("gx0040",!1,function(){var n,t;this.ServerClass="gx0040";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV11pentidafederativaid=gx.fn.getIntegerValue("vPENTIDAFEDERATIVAID",".")};this.Validv_Centidadfederativafecreg=function(){try{var n=gx.util.balloon.getNew("vCENTIDADFEDERATIVAFECREG");if(this.AnyError=0,!(new gx.date.gxdate("").compare(this.AV9centidadfederativafecreg)==0||new gx.date.gxdate(this.AV9centidadfederativafecreg).compare(gx.date.ymdhmstot(1753,01,01,00,00,00))>=0))try{n.setError("Campo entidadfederativafecreg fuera de rango");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Validv_Centidadfederativafecultact=function(){try{var n=gx.util.balloon.getNew("vCENTIDADFEDERATIVAFECULTACT");if(this.AnyError=0,!(new gx.date.gxdate("").compare(this.AV10centidadfederativafecultact)==0||new gx.date.gxdate(this.AV10centidadfederativafecultact).compare(gx.date.ymdhmstot(1753,01,01,00,00,00))>=0))try{n.setError("Campo entidadfederativafecultact fuera de rango");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e160a1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle"));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}])};this.e110a1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ENTIDAFEDERATIVAIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ENTIDAFEDERATIVAIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCENTIDAFEDERATIVAID","Visible",!0)):(gx.fn.setCtrlProperty("ENTIDAFEDERATIVAIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCENTIDAFEDERATIVAID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ENTIDAFEDERATIVAIDFILTERCONTAINER","Class")',ctrl:"ENTIDAFEDERATIVAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCENTIDAFEDERATIVAID","Visible")',ctrl:"vCENTIDAFEDERATIVAID",prop:"Visible"}])};this.e120a1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ENTIDADFEDERATIVADSCFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ENTIDADFEDERATIVADSCFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCENTIDADFEDERATIVADSC","Visible",!0)):(gx.fn.setCtrlProperty("ENTIDADFEDERATIVADSCFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCENTIDADFEDERATIVADSC","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ENTIDADFEDERATIVADSCFILTERCONTAINER","Class")',ctrl:"ENTIDADFEDERATIVADSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCENTIDADFEDERATIVADSC","Visible")',ctrl:"vCENTIDADFEDERATIVADSC",prop:"Visible"}])};this.e130a1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ENTIDADFEDERATIVAUSUARIOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ENTIDADFEDERATIVAUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCENTIDADFEDERATIVAUSUARIO","Visible",!0)):(gx.fn.setCtrlProperty("ENTIDADFEDERATIVAUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCENTIDADFEDERATIVAUSUARIO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ENTIDADFEDERATIVAUSUARIOFILTERCONTAINER","Class")',ctrl:"ENTIDADFEDERATIVAUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCENTIDADFEDERATIVAUSUARIO","Visible")',ctrl:"vCENTIDADFEDERATIVAUSUARIO",prop:"Visible"}])};this.e140a1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ENTIDADFEDERATIVAFECREGFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("ENTIDADFEDERATIVAFECREGFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("ENTIDADFEDERATIVAFECREGFILTERCONTAINER","Class","AdvancedContainerItem");this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ENTIDADFEDERATIVAFECREGFILTERCONTAINER","Class")',ctrl:"ENTIDADFEDERATIVAFECREGFILTERCONTAINER",prop:"Class"}])};this.e150a1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ENTIDADFEDERATIVAFECULTACTFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("ENTIDADFEDERATIVAFECULTACTFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("ENTIDADFEDERATIVAFECULTACTFILTERCONTAINER","Class","AdvancedContainerItem");this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ENTIDADFEDERATIVAFECULTACTFILTERCONTAINER","Class")',ctrl:"ENTIDADFEDERATIVAFECULTACTFILTERCONTAINER",prop:"Class"}])};this.e190a2_client=function(){this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e200a1_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,62,63,65,66,67,68,69];this.GXLastCtrlId=69;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",64,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0040",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",65,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(7,66,"ENTIDAFEDERATIVAID","entidafederativaid","","entidafederativaid","int",0,"px",9,9,"right",null,[],7,"entidafederativaid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(108,67,"ENTIDADFEDERATIVADSC","entidadfederativadsc","","entidadfederativadsc","svchar",0,"px",100,80,"left",null,[],108,"entidadfederativadsc",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");this.setGrid(t);n[2]={fld:"",grid:0};n[3]={fld:"MAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"ADVANCEDCONTAINER",grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"ENTIDAFEDERATIVAIDFILTERCONTAINER",grid:0};n[10]={fld:"",grid:0};n[11]={fld:"",grid:0};n[12]={fld:"LBLENTIDAFEDERATIVAIDFILTER",format:1,grid:0};n[13]={fld:"",grid:0};n[14]={fld:"",grid:0};n[15]={fld:"",grid:0};n[16]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCENTIDAFEDERATIVAID",gxz:"ZV6centidafederativaid",gxold:"OV6centidafederativaid",gxvar:"AV6centidafederativaid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6centidafederativaid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6centidafederativaid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCENTIDAFEDERATIVAID",gx.O.AV6centidafederativaid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6centidafederativaid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCENTIDAFEDERATIVAID",".")},nac:gx.falseFn};n[17]={fld:"",grid:0};n[18]={fld:"",grid:0};n[19]={fld:"ENTIDADFEDERATIVADSCFILTERCONTAINER",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={fld:"LBLENTIDADFEDERATIVADSCFILTER",format:1,grid:0};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCENTIDADFEDERATIVADSC",gxz:"ZV7centidadfederativadsc",gxold:"OV7centidadfederativadsc",gxvar:"AV7centidadfederativadsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7centidadfederativadsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7centidadfederativadsc=n)},v2c:function(){gx.fn.setControlValue("vCENTIDADFEDERATIVADSC",gx.O.AV7centidadfederativadsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7centidadfederativadsc=this.val())},val:function(){return gx.fn.getControlValue("vCENTIDADFEDERATIVADSC")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"ENTIDADFEDERATIVAUSUARIOFILTERCONTAINER",grid:0};n[30]={fld:"",grid:0};n[31]={fld:"",grid:0};n[32]={fld:"LBLENTIDADFEDERATIVAUSUARIOFILTER",format:1,grid:0};n[33]={fld:"",grid:0};n[34]={fld:"",grid:0};n[35]={fld:"",grid:0};n[36]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCENTIDADFEDERATIVAUSUARIO",gxz:"ZV8centidadfederativausuario",gxold:"OV8centidadfederativausuario",gxvar:"AV8centidadfederativausuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8centidadfederativausuario=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8centidadfederativausuario=n)},v2c:function(){gx.fn.setControlValue("vCENTIDADFEDERATIVAUSUARIO",gx.O.AV8centidadfederativausuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8centidadfederativausuario=this.val())},val:function(){return gx.fn.getControlValue("vCENTIDADFEDERATIVAUSUARIO")},nac:gx.falseFn};n[37]={fld:"",grid:0};n[38]={fld:"",grid:0};n[39]={fld:"ENTIDADFEDERATIVAFECREGFILTERCONTAINER",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={fld:"LBLENTIDADFEDERATIVAFECREGFILTER",format:1,grid:0};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Centidadfederativafecreg,isvalid:null,rgrid:[this.Grid1Container],fld:"vCENTIDADFEDERATIVAFECREG",gxz:"ZV9centidadfederativafecreg",gxold:"OV9centidadfederativafecreg",gxvar:"AV9centidadfederativafecreg",dp:{f:-1,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[46],ip:[46],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9centidadfederativafecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV9centidadfederativafecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCENTIDADFEDERATIVAFECREG",gx.O.AV9centidadfederativafecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9centidadfederativafecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vCENTIDADFEDERATIVAFECREG")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"ENTIDADFEDERATIVAFECULTACTFILTERCONTAINER",grid:0};n[50]={fld:"",grid:0};n[51]={fld:"",grid:0};n[52]={fld:"LBLENTIDADFEDERATIVAFECULTACTFILTER",format:1,grid:0};n[53]={fld:"",grid:0};n[54]={fld:"",grid:0};n[55]={fld:"",grid:0};n[56]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Centidadfederativafecultact,isvalid:null,rgrid:[this.Grid1Container],fld:"vCENTIDADFEDERATIVAFECULTACT",gxz:"ZV10centidadfederativafecultact",gxold:"OV10centidadfederativafecultact",gxvar:"AV10centidadfederativafecultact",dp:{f:-1,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[56],ip:[56],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10centidadfederativafecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV10centidadfederativafecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCENTIDADFEDERATIVAFECULTACT",gx.O.AV10centidadfederativafecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10centidadfederativafecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vCENTIDADFEDERATIVAFECULTACT")},nac:gx.falseFn};n[57]={fld:"",grid:0};n[58]={fld:"GRIDTABLE",grid:0};n[59]={fld:"",grid:0};n[60]={fld:"",grid:0};n[62]={fld:"",grid:0};n[63]={fld:"",grid:0};n[65]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64),gx.O.AV5LinkSelection,gx.O.AV15Linkselection_GXI)},c2v:function(){gx.O.AV15Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(64))},gxvar_GXI:"AV15Linkselection_GXI",nac:gx.falseFn};n[66]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ENTIDAFEDERATIVAID",gxz:"Z7entidafederativaid",gxold:"O7entidafederativaid",gxvar:"A7entidafederativaid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A7entidafederativaid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z7entidafederativaid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ENTIDAFEDERATIVAID",n||gx.fn.currentGridRowImpl(64),gx.O.A7entidafederativaid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A7entidafederativaid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ENTIDAFEDERATIVAID",n||gx.fn.currentGridRowImpl(64),".")},nac:gx.falseFn};n[67]={lvl:2,type:"svchar",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ENTIDADFEDERATIVADSC",gxz:"Z108entidadfederativadsc",gxold:"O108entidadfederativadsc",gxvar:"A108entidadfederativadsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A108entidadfederativadsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z108entidadfederativadsc=n)},v2c:function(n){gx.fn.setGridControlValue("ENTIDADFEDERATIVADSC",n||gx.fn.currentGridRowImpl(64),gx.O.A108entidadfederativadsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A108entidadfederativadsc=this.val())},val:function(n){return gx.fn.getGridControlValue("ENTIDADFEDERATIVADSC",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[68]={fld:"",grid:0};n[69]={fld:"",grid:0};this.AV6centidafederativaid=0;this.ZV6centidafederativaid=0;this.OV6centidafederativaid=0;this.AV7centidadfederativadsc="";this.ZV7centidadfederativadsc="";this.OV7centidadfederativadsc="";this.AV8centidadfederativausuario="";this.ZV8centidadfederativausuario="";this.OV8centidadfederativausuario="";this.AV9centidadfederativafecreg=gx.date.nullDate();this.ZV9centidadfederativafecreg=gx.date.nullDate();this.OV9centidadfederativafecreg=gx.date.nullDate();this.AV10centidadfederativafecultact=gx.date.nullDate();this.ZV10centidadfederativafecultact=gx.date.nullDate();this.OV10centidadfederativafecultact=gx.date.nullDate();this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z7entidafederativaid=0;this.O7entidafederativaid=0;this.Z108entidadfederativadsc="";this.O108entidadfederativadsc="";this.AV6centidafederativaid=0;this.AV7centidadfederativadsc="";this.AV8centidadfederativausuario="";this.AV9centidadfederativafecreg=gx.date.nullDate();this.AV10centidadfederativafecultact=gx.date.nullDate();this.AV11pentidafederativaid=0;this.A111entidadfederativafecultact=gx.date.nullDate();this.A110entidadfederativafecreg=gx.date.nullDate();this.A109entidadfederativausuario="";this.AV5LinkSelection="";this.A7entidafederativaid=0;this.A108entidadfederativadsc="";this.Events={e190a2_client:["ENTER",!0],e200a1_client:["CANCEL",!0],e160a1_client:["'TOGGLE'",!1],e110a1_client:["LBLENTIDAFEDERATIVAIDFILTER.CLICK",!1],e120a1_client:["LBLENTIDADFEDERATIVADSCFILTER.CLICK",!1],e130a1_client:["LBLENTIDADFEDERATIVAUSUARIOFILTER.CLICK",!1],e140a1_client:["LBLENTIDADFEDERATIVAFECREGFILTER.CLICK",!1],e150a1_client:["LBLENTIDADFEDERATIVAFECULTACTFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6centidafederativaid",fld:"vCENTIDAFEDERATIVAID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7centidadfederativadsc",fld:"vCENTIDADFEDERATIVADSC",pic:"",nv:""},{av:"AV8centidadfederativausuario",fld:"vCENTIDADFEDERATIVAUSUARIO",pic:"",nv:""},{av:"AV9centidadfederativafecreg",fld:"vCENTIDADFEDERATIVAFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10centidadfederativafecultact",fld:"vCENTIDADFEDERATIVAFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLENTIDAFEDERATIVAIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ENTIDAFEDERATIVAIDFILTERCONTAINER","Class")',ctrl:"ENTIDAFEDERATIVAIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ENTIDAFEDERATIVAIDFILTERCONTAINER","Class")',ctrl:"ENTIDAFEDERATIVAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCENTIDAFEDERATIVAID","Visible")',ctrl:"vCENTIDAFEDERATIVAID",prop:"Visible"}]];this.EvtParms["LBLENTIDADFEDERATIVADSCFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ENTIDADFEDERATIVADSCFILTERCONTAINER","Class")',ctrl:"ENTIDADFEDERATIVADSCFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ENTIDADFEDERATIVADSCFILTERCONTAINER","Class")',ctrl:"ENTIDADFEDERATIVADSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCENTIDADFEDERATIVADSC","Visible")',ctrl:"vCENTIDADFEDERATIVADSC",prop:"Visible"}]];this.EvtParms["LBLENTIDADFEDERATIVAUSUARIOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ENTIDADFEDERATIVAUSUARIOFILTERCONTAINER","Class")',ctrl:"ENTIDADFEDERATIVAUSUARIOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ENTIDADFEDERATIVAUSUARIOFILTERCONTAINER","Class")',ctrl:"ENTIDADFEDERATIVAUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCENTIDADFEDERATIVAUSUARIO","Visible")',ctrl:"vCENTIDADFEDERATIVAUSUARIO",prop:"Visible"}]];this.EvtParms["LBLENTIDADFEDERATIVAFECREGFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ENTIDADFEDERATIVAFECREGFILTERCONTAINER","Class")',ctrl:"ENTIDADFEDERATIVAFECREGFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ENTIDADFEDERATIVAFECREGFILTERCONTAINER","Class")',ctrl:"ENTIDADFEDERATIVAFECREGFILTERCONTAINER",prop:"Class"}]];this.EvtParms["LBLENTIDADFEDERATIVAFECULTACTFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ENTIDADFEDERATIVAFECULTACTFILTERCONTAINER","Class")',ctrl:"ENTIDADFEDERATIVAFECULTACTFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ENTIDADFEDERATIVAFECULTACTFILTERCONTAINER","Class")',ctrl:"ENTIDADFEDERATIVAFECULTACTFILTERCONTAINER",prop:"Class"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A7entidafederativaid",fld:"ENTIDAFEDERATIVAID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV11pentidafederativaid",fld:"vPENTIDAFEDERATIVAID",pic:"ZZZZZZZZ9",nv:0}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6centidafederativaid",fld:"vCENTIDAFEDERATIVAID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7centidadfederativadsc",fld:"vCENTIDADFEDERATIVADSC",pic:"",nv:""},{av:"AV8centidadfederativausuario",fld:"vCENTIDADFEDERATIVAUSUARIO",pic:"",nv:""},{av:"AV9centidadfederativafecreg",fld:"vCENTIDADFEDERATIVAFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10centidadfederativafecultact",fld:"vCENTIDADFEDERATIVAFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6centidafederativaid",fld:"vCENTIDAFEDERATIVAID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7centidadfederativadsc",fld:"vCENTIDADFEDERATIVADSC",pic:"",nv:""},{av:"AV8centidadfederativausuario",fld:"vCENTIDADFEDERATIVAUSUARIO",pic:"",nv:""},{av:"AV9centidadfederativafecreg",fld:"vCENTIDADFEDERATIVAFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10centidadfederativafecultact",fld:"vCENTIDADFEDERATIVAFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6centidafederativaid",fld:"vCENTIDAFEDERATIVAID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7centidadfederativadsc",fld:"vCENTIDADFEDERATIVADSC",pic:"",nv:""},{av:"AV8centidadfederativausuario",fld:"vCENTIDADFEDERATIVAUSUARIO",pic:"",nv:""},{av:"AV9centidadfederativafecreg",fld:"vCENTIDADFEDERATIVAFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10centidadfederativafecultact",fld:"vCENTIDADFEDERATIVAFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6centidafederativaid",fld:"vCENTIDAFEDERATIVAID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7centidadfederativadsc",fld:"vCENTIDADFEDERATIVADSC",pic:"",nv:""},{av:"AV8centidadfederativausuario",fld:"vCENTIDADFEDERATIVAUSUARIO",pic:"",nv:""},{av:"AV9centidadfederativafecreg",fld:"vCENTIDADFEDERATIVAFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10centidadfederativafecultact",fld:"vCENTIDADFEDERATIVAFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.setVCMap("AV11pentidafederativaid","vPENTIDAFEDERATIVAID",0,"int");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);this.InitStandaloneVars()});gx.createParentObj(gx0040)