/**@preserve  GeneXus C# 10_3_15-115824 on 1/29/2022 0:0:44.95
*/
gx.evt.autoSkip=!1;gx.define("catalog_de_categorias",!1,function(){this.ServerClass="catalog_de_categorias";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.A40000GXC1=gx.fn.getIntegerValue("GXC1",".");this.AV9categorias=gx.fn.getControlValue("vCATEGORIAS");this.Gx_date=gx.fn.getDateValue("vTODAY")};this.e12132_client=function(){this.executeServerEvent("'GUARDAR '",!1,null,!1,!1)};this.e13132_client=function(){this.executeServerEvent("'CONSULTAR '",!1,null,!1,!1)};this.e14132_client=function(){this.executeServerEvent("'CANCELAR'",!1,null,!1,!1)};this.e16132_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e17132_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[3,8,12,16,17];this.GXLastCtrlId=17;n[3]={fld:"TABLE1",grid:0};n[8]={fld:"TABLE2",grid:0};n[12]={lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vNEXTVALUE",gxz:"ZV6NextValue",gxold:"OV6NextValue",gxvar:"AV6NextValue",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6NextValue=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6NextValue=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vNEXTVALUE",gx.O.AV6NextValue,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6NextValue=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vNEXTVALUE",".")},nac:gx.falseFn};n[16]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vCATEGORIASDSC",gxz:"ZV7categoriasdsc",gxold:"OV7categoriasdsc",gxvar:"AV7categoriasdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7categoriasdsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7categoriasdsc=n)},v2c:function(){gx.fn.setControlValue("vCATEGORIASDSC",gx.O.AV7categoriasdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7categoriasdsc=this.val())},val:function(){return gx.fn.getControlValue("vCATEGORIASDSC")},nac:gx.falseFn};n[17]={fld:"TABLE3",grid:0};this.AV6NextValue=0;this.ZV6NextValue=0;this.OV6NextValue=0;this.AV7categoriasdsc="";this.ZV7categoriasdsc="";this.OV7categoriasdsc="";this.AV6NextValue=0;this.AV7categoriasdsc="";this.AV9categorias={};this.Gx_date=gx.date.nullDate();this.Events={e12132_client:["'GUARDAR '",!0],e13132_client:["'CONSULTAR '",!0],e14132_client:["'CANCELAR'",!0],e16132_client:["ENTER",!0],e17132_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms["'GUARDAR '"]=[[{av:"AV6NextValue",fld:"vNEXTVALUE",pic:"ZZZ9",hsh:!0,nv:0},{av:"AV9categorias",fld:"vCATEGORIAS",pic:"",nv:null},{av:"AV7categoriasdsc",fld:"vCATEGORIASDSC",pic:"",nv:""},{av:"Gx_date",fld:"vTODAY",pic:"",nv:""}],[{av:"AV9categorias",fld:"vCATEGORIAS",pic:"",nv:null}]];this.EvtParms["'CONSULTAR '"]=[[],[]];this.EvtParms["'CANCELAR'"]=[[],[]];this.setVCMap("A40000GXC1","GXC1",0,"int");this.setVCMap("AV9categorias","vCATEGORIAS",0,"categorias");this.setVCMap("Gx_date","vTODAY",0,"date");this.InitStandaloneVars()});gx.createParentObj(catalog_de_categorias)