/**@preserve  GeneXus C# 10_3_15-115824 on 3/31/2022 0:20:5.65
*/
gx.evt.autoSkip=!1;gx.define("gx00p0",!1,function(){var n,t;this.ServerClass="gx00p0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV8pestadoid=gx.fn.getIntegerValue("vPESTADOID",".")};this.e13381_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle"));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}])};this.e11381_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ESTADOIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ESTADOIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCESTADOID","Visible",!0)):(gx.fn.setCtrlProperty("ESTADOIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCESTADOID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ESTADOIDFILTERCONTAINER","Class")',ctrl:"ESTADOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCESTADOID","Visible")',ctrl:"vCESTADOID",prop:"Visible"}])};this.e12381_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ESTADOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ESTADOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCESTADO","Visible",!0)):(gx.fn.setCtrlProperty("ESTADOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCESTADO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ESTADOFILTERCONTAINER","Class")',ctrl:"ESTADOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCESTADO","Visible")',ctrl:"vCESTADO",prop:"Visible"}])};this.e16382_client=function(){this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e17381_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,32,33,35,36,37,38,39];this.GXLastCtrlId=39;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",34,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00p0",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",35,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(177,36,"ESTADOID","estadoid","","estadoid","int",0,"px",4,4,"right",null,[],177,"estadoid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(178,37,"ESTADO","estado","","estado","svchar",0,"px",100,80,"left",null,[],178,"estado",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");this.setGrid(t);n[2]={fld:"",grid:0};n[3]={fld:"MAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"ADVANCEDCONTAINER",grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"ESTADOIDFILTERCONTAINER",grid:0};n[10]={fld:"",grid:0};n[11]={fld:"",grid:0};n[12]={fld:"LBLESTADOIDFILTER",format:1,grid:0};n[13]={fld:"",grid:0};n[14]={fld:"",grid:0};n[15]={fld:"",grid:0};n[16]={lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCESTADOID",gxz:"ZV6cestadoid",gxold:"OV6cestadoid",gxvar:"AV6cestadoid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cestadoid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cestadoid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCESTADOID",gx.O.AV6cestadoid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cestadoid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCESTADOID",".")},nac:gx.falseFn};n[17]={fld:"",grid:0};n[18]={fld:"",grid:0};n[19]={fld:"ESTADOFILTERCONTAINER",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={fld:"LBLESTADOFILTER",format:1,grid:0};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCESTADO",gxz:"ZV7cestado",gxold:"OV7cestado",gxvar:"AV7cestado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cestado=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cestado=n)},v2c:function(){gx.fn.setControlValue("vCESTADO",gx.O.AV7cestado,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cestado=this.val())},val:function(){return gx.fn.getControlValue("vCESTADO")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"GRIDTABLE",grid:0};n[29]={fld:"",grid:0};n[30]={fld:"",grid:0};n[32]={fld:"",grid:0};n[33]={fld:"",grid:0};n[35]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34),gx.O.AV5LinkSelection,gx.O.AV12Linkselection_GXI)},c2v:function(){gx.O.AV12Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(34))},gxvar_GXI:"AV12Linkselection_GXI",nac:gx.falseFn};n[36]={lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ESTADOID",gxz:"Z177estadoid",gxold:"O177estadoid",gxvar:"A177estadoid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A177estadoid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z177estadoid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ESTADOID",n||gx.fn.currentGridRowImpl(34),gx.O.A177estadoid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A177estadoid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ESTADOID",n||gx.fn.currentGridRowImpl(34),".")},nac:gx.falseFn};n[37]={lvl:2,type:"svchar",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ESTADO",gxz:"Z178estado",gxold:"O178estado",gxvar:"A178estado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A178estado=n)},v2z:function(n){n!==undefined&&(gx.O.Z178estado=n)},v2c:function(n){gx.fn.setGridControlValue("ESTADO",n||gx.fn.currentGridRowImpl(34),gx.O.A178estado,0)},c2v:function(){this.val()!==undefined&&(gx.O.A178estado=this.val())},val:function(n){return gx.fn.getGridControlValue("ESTADO",n||gx.fn.currentGridRowImpl(34))},nac:gx.falseFn};n[38]={fld:"",grid:0};n[39]={fld:"",grid:0};this.AV6cestadoid=0;this.ZV6cestadoid=0;this.OV6cestadoid=0;this.AV7cestado="";this.ZV7cestado="";this.OV7cestado="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z177estadoid=0;this.O177estadoid=0;this.Z178estado="";this.O178estado="";this.AV6cestadoid=0;this.AV7cestado="";this.AV8pestadoid=0;this.AV5LinkSelection="";this.A177estadoid=0;this.A178estado="";this.Events={e16382_client:["ENTER",!0],e17381_client:["CANCEL",!0],e13381_client:["'TOGGLE'",!1],e11381_client:["LBLESTADOIDFILTER.CLICK",!1],e12381_client:["LBLESTADOFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cestadoid",fld:"vCESTADOID",pic:"ZZZ9",nv:0},{av:"AV7cestado",fld:"vCESTADO",pic:"",nv:""}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLESTADOIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ESTADOIDFILTERCONTAINER","Class")',ctrl:"ESTADOIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ESTADOIDFILTERCONTAINER","Class")',ctrl:"ESTADOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCESTADOID","Visible")',ctrl:"vCESTADOID",prop:"Visible"}]];this.EvtParms["LBLESTADOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ESTADOFILTERCONTAINER","Class")',ctrl:"ESTADOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ESTADOFILTERCONTAINER","Class")',ctrl:"ESTADOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCESTADO","Visible")',ctrl:"vCESTADO",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A177estadoid",fld:"ESTADOID",pic:"ZZZ9",hsh:!0,nv:0}],[{av:"AV8pestadoid",fld:"vPESTADOID",pic:"ZZZ9",nv:0}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cestadoid",fld:"vCESTADOID",pic:"ZZZ9",nv:0},{av:"AV7cestado",fld:"vCESTADO",pic:"",nv:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cestadoid",fld:"vCESTADOID",pic:"ZZZ9",nv:0},{av:"AV7cestado",fld:"vCESTADO",pic:"",nv:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cestadoid",fld:"vCESTADOID",pic:"ZZZ9",nv:0},{av:"AV7cestado",fld:"vCESTADO",pic:"",nv:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cestadoid",fld:"vCESTADOID",pic:"ZZZ9",nv:0},{av:"AV7cestado",fld:"vCESTADO",pic:"",nv:""}],[]];this.setVCMap("AV8pestadoid","vPESTADOID",0,"int");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);this.InitStandaloneVars()});gx.createParentObj(gx00p0)