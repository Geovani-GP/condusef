/**@preserve  GeneXus C# 10_3_15-115824 on 3/31/2022 0:19:31.35
*/
gx.evt.autoSkip=!1;gx.define("catalog_de_marcas",!1,function(){this.ServerClass="catalog_de_marcas";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.A40000GXC1=gx.fn.getIntegerValue("GXC1",".");this.AV14marcas=gx.fn.getControlValue("vMARCAS");this.Gx_date=gx.fn.getDateValue("vTODAY")};this.e120v2_client=function(){this.executeServerEvent("'GUARDAR '",!1,null,!1,!1)};this.e130v2_client=function(){this.executeServerEvent("'CONSULTAR '",!1,null,!1,!1)};this.e140v2_client=function(){this.executeServerEvent("'CANCELAR'",!1,null,!1,!1)};this.e160v2_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e170v2_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[4,7,10,14,18,19];this.GXLastCtrlId=19;n[4]={fld:"TABLE1",grid:0};n[7]={fld:"TEXTBLOCK8",format:0,grid:0};n[10]={fld:"TABLE2",grid:0};n[14]={lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vNEXTVALUE",gxz:"ZV6NextValue",gxold:"OV6NextValue",gxvar:"AV6NextValue",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6NextValue=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6NextValue=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vNEXTVALUE",gx.O.AV6NextValue,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6NextValue=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vNEXTVALUE",".")},nac:gx.falseFn};n[18]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vMARCASDSC",gxz:"ZV15marcasdsc",gxold:"OV15marcasdsc",gxvar:"AV15marcasdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV15marcasdsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV15marcasdsc=n)},v2c:function(){gx.fn.setControlValue("vMARCASDSC",gx.O.AV15marcasdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV15marcasdsc=this.val())},val:function(){return gx.fn.getControlValue("vMARCASDSC")},nac:gx.falseFn};n[19]={fld:"TABLE3",grid:0};this.AV6NextValue=0;this.ZV6NextValue=0;this.OV6NextValue=0;this.AV15marcasdsc="";this.ZV15marcasdsc="";this.OV15marcasdsc="";this.AV6NextValue=0;this.AV15marcasdsc="";this.AV14marcas={};this.Gx_date=gx.date.nullDate();this.Events={e120v2_client:["'GUARDAR '",!0],e130v2_client:["'CONSULTAR '",!0],e140v2_client:["'CANCELAR'",!0],e160v2_client:["ENTER",!0],e170v2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms["'GUARDAR '"]=[[{av:"AV15marcasdsc",fld:"vMARCASDSC",pic:"",nv:""},{av:"AV6NextValue",fld:"vNEXTVALUE",pic:"ZZZ9",hsh:!0,nv:0},{av:"AV14marcas",fld:"vMARCAS",pic:"",nv:null},{av:"Gx_date",fld:"vTODAY",pic:"",nv:""}],[{av:"AV14marcas",fld:"vMARCAS",pic:"",nv:null}]];this.EvtParms["'CONSULTAR '"]=[[],[]];this.EvtParms["'CANCELAR'"]=[[],[]];this.setVCMap("A40000GXC1","GXC1",0,"int");this.setVCMap("AV14marcas","vMARCAS",0,"marcas");this.setVCMap("Gx_date","vTODAY",0,"date");this.InitStandaloneVars()});gx.createParentObj(catalog_de_marcas)