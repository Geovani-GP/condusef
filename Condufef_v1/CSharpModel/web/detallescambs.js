/**@preserve  GeneXus C# 10_3_15-115824 on 1/26/2022 20:7:48.13
*/
gx.evt.autoSkip=!1;gx.define("detallescambs",!1,function(){var t,n;this.ServerClass="detallescambs";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.Valid_Cambsid=function(){try{if(gx.fn.currentGridRowImpl(11)===0)return!0;var n=gx.util.balloon.getNew("CAMBSID",gx.fn.currentGridRowImpl(11));this.AnyError=0;this.StandaloneModal();this.StandaloneNotModal()}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Cambsdsc=function(){try{if(gx.fn.currentGridRowImpl(11)===0)return!0;var n=gx.util.balloon.getNew("CAMBSDSC",gx.fn.currentGridRowImpl(11));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Cambsdsc=function(){try{if(gx.fn.currentGridRowImpl(11)===0)return!0;var n=gx.util.balloon.getNew("CAMBSDSC",gx.fn.currentGridRowImpl(11));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e122e2_client=function(){this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e132e2_client=function(){this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,5,12,13];this.GXLastCtrlId=13;this.CambsgridContainer=new gx.grid.grid(this,2,"WbpLvl2",11,"Cambsgrid","Cambsgrid","CambsgridContainer",this.CmpContext,this.IsMasterPage,"detallescambs",[],!1,1,!1,!0,0,!1,!1,!1,"",0,"px","Nueva fila",!1,!1,!1,null,null,!1,"",!1,[1,1,1,1]);n=this.CambsgridContainer;n.addSingleLineEdit(25,12,"CAMBSID","cambsid","","cambsid","int",0,"px",9,9,"left",null,[],25,"cambsid",!0,0,!1,!1,"Attribute",1,"");n.addSingleLineEdit(83,13,"CAMBSDSC","cambsdsc","","cambsdsc","svchar",0,"px",100,80,"left",null,[],83,"cambsdsc",!0,0,!1,!1,"Attribute",1,"");this.setGrid(n);t[2]={fld:"TABLE1",grid:0};t[5]={lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vBUSCAR",gxz:"ZV6buscar",gxold:"OV6buscar",gxvar:"AV6buscar",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6buscar=n)},v2z:function(n){n!==undefined&&(gx.O.ZV6buscar=n)},v2c:function(){gx.fn.setControlValue("vBUSCAR",gx.O.AV6buscar,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6buscar=this.val())},val:function(){return gx.fn.getControlValue("vBUSCAR")},nac:gx.falseFn};t[12]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:11,gxgrid:this.CambsgridContainer,fnc:this.Valid_Cambsid,isvalid:null,rgrid:[],fld:"CAMBSID",gxz:"Z25cambsid",gxold:"O25cambsid",gxvar:"A25cambsid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A25cambsid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z25cambsid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CAMBSID",n||gx.fn.currentGridRowImpl(11),gx.O.A25cambsid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A25cambsid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("CAMBSID",n||gx.fn.currentGridRowImpl(11),".")},nac:gx.falseFn};t[13]={lvl:2,type:"svchar",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.CambsgridContainer,fnc:this.Valid_Cambsdsc,isvalid:null,rgrid:[],fld:"CAMBSDSC",gxz:"Z83cambsdsc",gxold:"O83cambsdsc",gxvar:"A83cambsdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A83cambsdsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z83cambsdsc=n)},v2c:function(n){gx.fn.setGridControlValue("CAMBSDSC",n||gx.fn.currentGridRowImpl(11),gx.O.A83cambsdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A83cambsdsc=this.val())},val:function(n){return gx.fn.getGridControlValue("CAMBSDSC",n||gx.fn.currentGridRowImpl(11))},nac:gx.falseFn};this.AV6buscar="";this.ZV6buscar="";this.OV6buscar="";this.Z25cambsid=0;this.O25cambsid=0;this.Z83cambsdsc="";this.O83cambsdsc="";this.AV6buscar="";this.A25cambsid=0;this.A83cambsdsc="";this.Events={e122e2_client:["ENTER",!0],e132e2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"CAMBSGRID_nFirstRecordOnPage",nv:0},{av:"CAMBSGRID_nEOF",nv:0},{av:"A25cambsid",fld:"CAMBSID",pic:"ZZZZZZZZ9",hsh:!0,nv:0},{av:"A83cambsdsc",fld:"CAMBSDSC",pic:"",hsh:!0,nv:""},{av:"AV6buscar",fld:"vBUSCAR",pic:"",nv:""}],[]];this.EvtParms["CAMBSGRID.LOAD"]=[[{av:"A25cambsid",fld:"CAMBSID",pic:"ZZZZZZZZ9",hsh:!0,nv:0},{av:"A83cambsdsc",fld:"CAMBSDSC",pic:"",hsh:!0,nv:""},{av:"AV6buscar",fld:"vBUSCAR",pic:"",nv:""}],[]];n.addRefreshingVar({rfrVar:"A25cambsid",rfrProp:"Value",gxAttId:"25"});n.addRefreshingVar({rfrVar:"A83cambsdsc",rfrProp:"Value",gxAttId:"83"});n.addRefreshingVar(this.GXValidFnc[5]);this.InitStandaloneVars()});gx.createParentObj(detallescambs)