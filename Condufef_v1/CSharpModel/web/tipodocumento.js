/**@preserve  GeneXus C# 10_3_15-115824 on 1/28/2022 11:56:27.37
*/
gx.evt.autoSkip=!1;gx.define("tipodocumento",!1,function(){this.ServerClass="tipodocumento";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV8tipodocumentoid=gx.fn.getIntegerValue("vTIPODOCUMENTOID",".");this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Tipodocumentoid=function(){try{var n=gx.util.balloon.getNew("TIPODOCUMENTOID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e110k20_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e120k20_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,16,17,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41];this.GXLastCtrlId=41;n[2]={fld:"",grid:0};n[3]={fld:"TABLEMAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"TITLE",format:0,grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"",grid:0};n[10]={fld:"",grid:0};n[16]={fld:"",grid:0};n[17]={fld:"",grid:0};n[19]={fld:"",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Tipodocumentoid,isvalid:null,rgrid:[],fld:"TIPODOCUMENTOID",gxz:"Z26tipodocumentoid",gxold:"O26tipodocumentoid",gxvar:"A26tipodocumentoid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A26tipodocumentoid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z26tipodocumentoid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("TIPODOCUMENTOID",gx.O.A26tipodocumentoid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A26tipodocumentoid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("TIPODOCUMENTOID",".")},nac:gx.falseFn};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"TIPODOCUMENTODSC",gxz:"Z79tipodocumentodsc",gxold:"O79tipodocumentodsc",gxvar:"A79tipodocumentodsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A79tipodocumentodsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z79tipodocumentodsc=n)},v2c:function(){gx.fn.setControlValue("TIPODOCUMENTODSC",gx.O.A79tipodocumentodsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A79tipodocumentodsc=this.val())},val:function(){return gx.fn.getControlValue("TIPODOCUMENTODSC")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"",grid:0};n[30]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"TIPODOCUMENTOUSUARIO",gxz:"Z80tipodocumentousuario",gxold:"O80tipodocumentousuario",gxvar:"A80tipodocumentousuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A80tipodocumentousuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z80tipodocumentousuario=n)},v2c:function(){gx.fn.setControlValue("TIPODOCUMENTOUSUARIO",gx.O.A80tipodocumentousuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A80tipodocumentousuario=this.val())},val:function(){return gx.fn.getControlValue("TIPODOCUMENTOUSUARIO")},nac:gx.falseFn};n[31]={fld:"",grid:0};n[32]={fld:"",grid:0};n[33]={fld:"",grid:0};n[34]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"TIPODOCUMENTOFECREG",gxz:"Z81tipodocumentofecreg",gxold:"O81tipodocumentofecreg",gxvar:"A81tipodocumentofecreg",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A81tipodocumentofecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z81tipodocumentofecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("TIPODOCUMENTOFECREG",gx.O.A81tipodocumentofecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A81tipodocumentofecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("TIPODOCUMENTOFECREG")},nac:gx.falseFn};n[35]={fld:"",grid:0};n[36]={fld:"",grid:0};n[37]={fld:"",grid:0};n[38]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"TIPODOCUMENTOFECULTACT",gxz:"Z82tipodocumentofecultact",gxold:"O82tipodocumentofecultact",gxvar:"A82tipodocumentofecultact",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A82tipodocumentofecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z82tipodocumentofecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("TIPODOCUMENTOFECULTACT",gx.O.A82tipodocumentofecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.A82tipodocumentofecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("TIPODOCUMENTOFECULTACT")},nac:gx.falseFn};n[39]={fld:"",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};this.A26tipodocumentoid=0;this.Z26tipodocumentoid=0;this.O26tipodocumentoid=0;this.A79tipodocumentodsc="";this.Z79tipodocumentodsc="";this.O79tipodocumentodsc="";this.A80tipodocumentousuario="";this.Z80tipodocumentousuario="";this.O80tipodocumentousuario="";this.A81tipodocumentofecreg=gx.date.nullDate();this.Z81tipodocumentofecreg=gx.date.nullDate();this.O81tipodocumentofecreg=gx.date.nullDate();this.A82tipodocumentofecultact=gx.date.nullDate();this.Z82tipodocumentofecultact=gx.date.nullDate();this.O82tipodocumentofecultact=gx.date.nullDate();this.AV8tipodocumentoid=0;this.A26tipodocumentoid=0;this.A79tipodocumentodsc="";this.A80tipodocumentousuario="";this.A81tipodocumentofecreg=gx.date.nullDate();this.A82tipodocumentofecultact=gx.date.nullDate();this.Gx_mode="";this.Events={e110k20_client:["ENTER",!0],e120k20_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0,nv:""},{av:"AV8tipodocumentoid",fld:"vTIPODOCUMENTOID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("AV8tipodocumentoid","vTIPODOCUMENTOID",0,"int");this.setVCMap("Gx_mode","vMODE",0,"char");this.InitStandaloneVars()});gx.createParentObj(tipodocumento)