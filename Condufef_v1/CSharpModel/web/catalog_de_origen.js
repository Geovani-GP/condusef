/**@preserve  GeneXus C# 10_3_15-115824 on 2/15/2022 5:9:20.23
*/
gx.evt.autoSkip=!1;gx.define("catalog_de_origen",!1,function(){this.ServerClass="catalog_de_origen";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.A40000GXC1=gx.fn.getIntegerValue("GXC1",".");this.AV14origen=gx.fn.getControlValue("vORIGEN");this.Gx_date=gx.fn.getDateValue("vTODAY")};this.e12142_client=function(){this.executeServerEvent("'GUARDAR '",!1,null,!1,!1)};this.e13142_client=function(){this.executeServerEvent("'CONSULTAR '",!1,null,!1,!1)};this.e14142_client=function(){this.executeServerEvent("'CANCELAR'",!1,null,!1,!1)};this.e16142_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e17142_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[4,7,10,14,18,22,23];this.GXLastCtrlId=23;n[4]={fld:"TABLE1",grid:0};n[7]={fld:"TEXTBLOCK8",format:0,grid:0};n[10]={fld:"TABLE2",grid:0};n[14]={lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vNEXTVALUE",gxz:"ZV6NextValue",gxold:"OV6NextValue",gxvar:"AV6NextValue",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6NextValue=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6NextValue=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vNEXTVALUE",gx.O.AV6NextValue,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6NextValue=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vNEXTVALUE",".")},nac:gx.falseFn};n[18]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vORIGENDSCORTA",gxz:"ZV8origendscorta",gxold:"OV8origendscorta",gxvar:"AV8origendscorta",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8origendscorta=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8origendscorta=n)},v2c:function(){gx.fn.setControlValue("vORIGENDSCORTA",gx.O.AV8origendscorta,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8origendscorta=this.val())},val:function(){return gx.fn.getControlValue("vORIGENDSCORTA")},nac:gx.falseFn};n[22]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vORIGENDSCLARGA",gxz:"ZV9origendsclarga",gxold:"OV9origendsclarga",gxvar:"AV9origendsclarga",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9origendsclarga=n)},v2z:function(n){n!==undefined&&(gx.O.ZV9origendsclarga=n)},v2c:function(){gx.fn.setControlValue("vORIGENDSCLARGA",gx.O.AV9origendsclarga,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9origendsclarga=this.val())},val:function(){return gx.fn.getControlValue("vORIGENDSCLARGA")},nac:gx.falseFn};n[23]={fld:"TABLE3",grid:0};this.AV6NextValue=0;this.ZV6NextValue=0;this.OV6NextValue=0;this.AV8origendscorta="";this.ZV8origendscorta="";this.OV8origendscorta="";this.AV9origendsclarga="";this.ZV9origendsclarga="";this.OV9origendsclarga="";this.AV6NextValue=0;this.AV8origendscorta="";this.AV9origendsclarga="";this.AV14origen={};this.Gx_date=gx.date.nullDate();this.Events={e12142_client:["'GUARDAR '",!0],e13142_client:["'CONSULTAR '",!0],e14142_client:["'CANCELAR'",!0],e16142_client:["ENTER",!0],e17142_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms["'GUARDAR '"]=[[{av:"AV8origendscorta",fld:"vORIGENDSCORTA",pic:"",nv:""},{av:"AV9origendsclarga",fld:"vORIGENDSCLARGA",pic:"",nv:""},{av:"AV6NextValue",fld:"vNEXTVALUE",pic:"ZZZ9",hsh:!0,nv:0},{av:"AV14origen",fld:"vORIGEN",pic:"",nv:null},{av:"Gx_date",fld:"vTODAY",pic:"",nv:""}],[{av:"AV14origen",fld:"vORIGEN",pic:"",nv:null}]];this.EvtParms["'CONSULTAR '"]=[[],[]];this.EvtParms["'CANCELAR'"]=[[],[]];this.setVCMap("A40000GXC1","GXC1",0,"int");this.setVCMap("AV14origen","vORIGEN",0,"origen");this.setVCMap("Gx_date","vTODAY",0,"date");this.InitStandaloneVars()});gx.createParentObj(catalog_de_origen)