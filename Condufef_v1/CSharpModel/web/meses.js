/**@preserve  GeneXus C# 10_3_15-115824 on 1/30/2022 23:37:21.24
*/
gx.evt.autoSkip=!1;gx.define("meses",!1,function(){this.ServerClass="meses";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Mesesid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Mesesid",["gx.O.A11mesesid","gx.O.A61mesesanio","gx.O.A62mesesusuario",'gx.date.urlDateTime(gx.O.A63mesesfecgre,"DMY")','gx.date.urlDateTime(gx.O.A64mesesfeact,"DMY")'],["A61mesesanio","A62mesesusuario","A63mesesfecgre","A64mesesfeact","Gx_mode","Z11mesesid","Z61mesesanio","Z62mesesusuario","Z63mesesfecgre","Z64mesesfeact",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.e11033_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e12033_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,16,17,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41];this.GXLastCtrlId=41;n[2]={fld:"",grid:0};n[3]={fld:"TABLEMAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"TITLE",format:0,grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"",grid:0};n[10]={fld:"",grid:0};n[16]={fld:"",grid:0};n[17]={fld:"",grid:0};n[19]={fld:"",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Mesesid,isvalid:null,rgrid:[],fld:"MESESID",gxz:"Z11mesesid",gxold:"O11mesesid",gxvar:"A11mesesid",ucs:[],op:[38,34,30,26],ip:[38,34,30,26,22],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A11mesesid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z11mesesid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("MESESID",gx.O.A11mesesid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A11mesesid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("MESESID",".")},nac:gx.falseFn};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:5,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"MESESANIO",gxz:"Z61mesesanio",gxold:"O61mesesanio",gxvar:"A61mesesanio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A61mesesanio=n)},v2z:function(n){n!==undefined&&(gx.O.Z61mesesanio=n)},v2c:function(){gx.fn.setControlValue("MESESANIO",gx.O.A61mesesanio,0)},c2v:function(){this.val()!==undefined&&(gx.O.A61mesesanio=this.val())},val:function(){return gx.fn.getControlValue("MESESANIO")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"",grid:0};n[30]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"MESESUSUARIO",gxz:"Z62mesesusuario",gxold:"O62mesesusuario",gxvar:"A62mesesusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A62mesesusuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z62mesesusuario=n)},v2c:function(){gx.fn.setControlValue("MESESUSUARIO",gx.O.A62mesesusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A62mesesusuario=this.val())},val:function(){return gx.fn.getControlValue("MESESUSUARIO")},nac:gx.falseFn};n[31]={fld:"",grid:0};n[32]={fld:"",grid:0};n[33]={fld:"",grid:0};n[34]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"MESESFECGRE",gxz:"Z63mesesfecgre",gxold:"O63mesesfecgre",gxvar:"A63mesesfecgre",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A63mesesfecgre=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z63mesesfecgre=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("MESESFECGRE",gx.O.A63mesesfecgre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A63mesesfecgre=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("MESESFECGRE")},nac:gx.falseFn};n[35]={fld:"",grid:0};n[36]={fld:"",grid:0};n[37]={fld:"",grid:0};n[38]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"MESESFEACT",gxz:"Z64mesesfeact",gxold:"O64mesesfeact",gxvar:"A64mesesfeact",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A64mesesfeact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z64mesesfeact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("MESESFEACT",gx.O.A64mesesfeact,0)},c2v:function(){this.val()!==undefined&&(gx.O.A64mesesfeact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("MESESFEACT")},nac:gx.falseFn};n[39]={fld:"",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};this.A11mesesid=0;this.Z11mesesid=0;this.O11mesesid=0;this.A61mesesanio="";this.Z61mesesanio="";this.O61mesesanio="";this.A62mesesusuario="";this.Z62mesesusuario="";this.O62mesesusuario="";this.A63mesesfecgre=gx.date.nullDate();this.Z63mesesfecgre=gx.date.nullDate();this.O63mesesfecgre=gx.date.nullDate();this.A64mesesfeact=gx.date.nullDate();this.Z64mesesfeact=gx.date.nullDate();this.O64mesesfeact=gx.date.nullDate();this.A11mesesid=0;this.A61mesesanio="";this.A62mesesusuario="";this.A63mesesfecgre=gx.date.nullDate();this.A64mesesfeact=gx.date.nullDate();this.Events={e11033_client:["ENTER",!0],e12033_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char");this.InitStandaloneVars()});gx.createParentObj(meses)