/**@preserve  GeneXus C# 10_3_15-115824 on 1/25/2022 17:35:39.81
*/
gx.evt.autoSkip=!1;gx.define("gx00f0",!1,function(){var n,t;this.ServerClass="gx00f0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV9pidusuario=gx.fn.getIntegerValue("vPIDUSUARIO",".")};this.e14271_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle"));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}])};this.e11271_client=function(){this.clearMessages();gx.fn.getCtrlProperty("IDUSUARIOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("IDUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCIDUSUARIO","Visible",!0)):(gx.fn.setCtrlProperty("IDUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCIDUSUARIO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("IDUSUARIOFILTERCONTAINER","Class")',ctrl:"IDUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCIDUSUARIO","Visible")',ctrl:"vCIDUSUARIO",prop:"Visible"}])};this.e12271_client=function(){this.clearMessages();gx.fn.getCtrlProperty("USUARIOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("USUARIOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCUSUARIO","Visible",!0)):(gx.fn.setCtrlProperty("USUARIOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCUSUARIO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("USUARIOFILTERCONTAINER","Class")',ctrl:"USUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUARIO","Visible")',ctrl:"vCUSUARIO",prop:"Visible"}])};this.e13271_client=function(){this.clearMessages();gx.fn.getCtrlProperty("CONTRASENAFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CONTRASENAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCONTRASENA","Visible",!0)):(gx.fn.setCtrlProperty("CONTRASENAFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCONTRASENA","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CONTRASENAFILTERCONTAINER","Class")',ctrl:"CONTRASENAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCONTRASENA","Visible")',ctrl:"vCCONTRASENA",prop:"Visible"}])};this.e17272_client=function(){this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e18271_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,42,43,45,46,47,48,49,50];this.GXLastCtrlId=50;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",44,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00f0",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",45,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(9,46,"IDUSUARIO","idusuario","","idusuario","int",0,"px",9,9,"right",null,[],9,"idusuario",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(173,47,"USUARIO","usuario","","usuario","svchar",0,"px",25,25,"left",null,[],173,"usuario",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(174,48,"CONTRASENA","contrasena","","contrasena","svchar",0,"px",10,10,"left",null,[],174,"contrasena",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.setGrid(t);n[2]={fld:"",grid:0};n[3]={fld:"MAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"ADVANCEDCONTAINER",grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"IDUSUARIOFILTERCONTAINER",grid:0};n[10]={fld:"",grid:0};n[11]={fld:"",grid:0};n[12]={fld:"LBLIDUSUARIOFILTER",format:1,grid:0};n[13]={fld:"",grid:0};n[14]={fld:"",grid:0};n[15]={fld:"",grid:0};n[16]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCIDUSUARIO",gxz:"ZV6cidusuario",gxold:"OV6cidusuario",gxvar:"AV6cidusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cidusuario=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cidusuario=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCIDUSUARIO",gx.O.AV6cidusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cidusuario=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCIDUSUARIO",".")},nac:gx.falseFn};n[17]={fld:"",grid:0};n[18]={fld:"",grid:0};n[19]={fld:"USUARIOFILTERCONTAINER",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={fld:"LBLUSUARIOFILTER",format:1,grid:0};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:25,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCUSUARIO",gxz:"ZV7cusuario",gxold:"OV7cusuario",gxvar:"AV7cusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cusuario=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cusuario=n)},v2c:function(){gx.fn.setControlValue("vCUSUARIO",gx.O.AV7cusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cusuario=this.val())},val:function(){return gx.fn.getControlValue("vCUSUARIO")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"CONTRASENAFILTERCONTAINER",grid:0};n[30]={fld:"",grid:0};n[31]={fld:"",grid:0};n[32]={fld:"LBLCONTRASENAFILTER",format:1,grid:0};n[33]={fld:"",grid:0};n[34]={fld:"",grid:0};n[35]={fld:"",grid:0};n[36]={lvl:0,type:"svchar",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCONTRASENA",gxz:"ZV8ccontrasena",gxold:"OV8ccontrasena",gxvar:"AV8ccontrasena",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8ccontrasena=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8ccontrasena=n)},v2c:function(){gx.fn.setControlValue("vCCONTRASENA",gx.O.AV8ccontrasena,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8ccontrasena=this.val())},val:function(){return gx.fn.getControlValue("vCCONTRASENA")},nac:gx.falseFn};n[37]={fld:"",grid:0};n[38]={fld:"GRIDTABLE",grid:0};n[39]={fld:"",grid:0};n[40]={fld:"",grid:0};n[42]={fld:"",grid:0};n[43]={fld:"",grid:0};n[45]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(44),gx.O.AV5LinkSelection,gx.O.AV13Linkselection_GXI)},c2v:function(){gx.O.AV13Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(44))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(44))},gxvar_GXI:"AV13Linkselection_GXI",nac:gx.falseFn};n[46]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"IDUSUARIO",gxz:"Z9idusuario",gxold:"O9idusuario",gxvar:"A9idusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A9idusuario=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z9idusuario=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("IDUSUARIO",n||gx.fn.currentGridRowImpl(44),gx.O.A9idusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A9idusuario=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("IDUSUARIO",n||gx.fn.currentGridRowImpl(44),".")},nac:gx.falseFn};n[47]={lvl:2,type:"svchar",len:25,dec:0,sign:!1,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"USUARIO",gxz:"Z173usuario",gxold:"O173usuario",gxvar:"A173usuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A173usuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z173usuario=n)},v2c:function(n){gx.fn.setGridControlValue("USUARIO",n||gx.fn.currentGridRowImpl(44),gx.O.A173usuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A173usuario=this.val())},val:function(n){return gx.fn.getGridControlValue("USUARIO",n||gx.fn.currentGridRowImpl(44))},nac:gx.falseFn};n[48]={lvl:2,type:"svchar",len:10,dec:0,sign:!1,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"CONTRASENA",gxz:"Z174contrasena",gxold:"O174contrasena",gxvar:"A174contrasena",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A174contrasena=n)},v2z:function(n){n!==undefined&&(gx.O.Z174contrasena=n)},v2c:function(n){gx.fn.setGridControlValue("CONTRASENA",n||gx.fn.currentGridRowImpl(44),gx.O.A174contrasena,0)},c2v:function(){this.val()!==undefined&&(gx.O.A174contrasena=this.val())},val:function(n){return gx.fn.getGridControlValue("CONTRASENA",n||gx.fn.currentGridRowImpl(44))},nac:gx.falseFn};n[49]={fld:"",grid:0};n[50]={fld:"",grid:0};this.AV6cidusuario=0;this.ZV6cidusuario=0;this.OV6cidusuario=0;this.AV7cusuario="";this.ZV7cusuario="";this.OV7cusuario="";this.AV8ccontrasena="";this.ZV8ccontrasena="";this.OV8ccontrasena="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z9idusuario=0;this.O9idusuario=0;this.Z173usuario="";this.O173usuario="";this.Z174contrasena="";this.O174contrasena="";this.AV6cidusuario=0;this.AV7cusuario="";this.AV8ccontrasena="";this.AV9pidusuario=0;this.AV5LinkSelection="";this.A9idusuario=0;this.A173usuario="";this.A174contrasena="";this.Events={e17272_client:["ENTER",!0],e18271_client:["CANCEL",!0],e14271_client:["'TOGGLE'",!1],e11271_client:["LBLIDUSUARIOFILTER.CLICK",!1],e12271_client:["LBLUSUARIOFILTER.CLICK",!1],e13271_client:["LBLCONTRASENAFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cidusuario",fld:"vCIDUSUARIO",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cusuario",fld:"vCUSUARIO",pic:"",nv:""},{av:"AV8ccontrasena",fld:"vCCONTRASENA",pic:"",nv:""}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLIDUSUARIOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("IDUSUARIOFILTERCONTAINER","Class")',ctrl:"IDUSUARIOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("IDUSUARIOFILTERCONTAINER","Class")',ctrl:"IDUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCIDUSUARIO","Visible")',ctrl:"vCIDUSUARIO",prop:"Visible"}]];this.EvtParms["LBLUSUARIOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("USUARIOFILTERCONTAINER","Class")',ctrl:"USUARIOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("USUARIOFILTERCONTAINER","Class")',ctrl:"USUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUARIO","Visible")',ctrl:"vCUSUARIO",prop:"Visible"}]];this.EvtParms["LBLCONTRASENAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CONTRASENAFILTERCONTAINER","Class")',ctrl:"CONTRASENAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CONTRASENAFILTERCONTAINER","Class")',ctrl:"CONTRASENAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCONTRASENA","Visible")',ctrl:"vCCONTRASENA",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A9idusuario",fld:"IDUSUARIO",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV9pidusuario",fld:"vPIDUSUARIO",pic:"ZZZZZZZZ9",nv:0}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cidusuario",fld:"vCIDUSUARIO",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cusuario",fld:"vCUSUARIO",pic:"",nv:""},{av:"AV8ccontrasena",fld:"vCCONTRASENA",pic:"",nv:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cidusuario",fld:"vCIDUSUARIO",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cusuario",fld:"vCUSUARIO",pic:"",nv:""},{av:"AV8ccontrasena",fld:"vCCONTRASENA",pic:"",nv:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cidusuario",fld:"vCIDUSUARIO",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cusuario",fld:"vCUSUARIO",pic:"",nv:""},{av:"AV8ccontrasena",fld:"vCCONTRASENA",pic:"",nv:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cidusuario",fld:"vCIDUSUARIO",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cusuario",fld:"vCUSUARIO",pic:"",nv:""},{av:"AV8ccontrasena",fld:"vCCONTRASENA",pic:"",nv:""}],[]];this.setVCMap("AV9pidusuario","vPIDUSUARIO",0,"int");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);this.InitStandaloneVars()});gx.createParentObj(gx00f0)