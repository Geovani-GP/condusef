/**@preserve  GeneXus C# 10_3_15-115824 on 2/5/2022 15:59:35.92
*/
gx.evt.autoSkip=!1;gx.define("empleadospiso",!1,function(){this.ServerClass="empleadospiso";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV7empleadospisoextid=gx.fn.getIntegerValue("vEMPLEADOSPISOEXTID",".");this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Empleadospisoextid=function(){try{var n=gx.util.balloon.getNew("EMPLEADOSPISOEXTID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e110o24_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e120o24_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,16,17,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53];this.GXLastCtrlId=53;n[2]={fld:"",grid:0};n[3]={fld:"TABLEMAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"TITLE",format:0,grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"",grid:0};n[10]={fld:"",grid:0};n[16]={fld:"",grid:0};n[17]={fld:"",grid:0};n[19]={fld:"",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Empleadospisoextid,isvalid:null,rgrid:[],fld:"EMPLEADOSPISOEXTID",gxz:"Z46empleadospisoextid",gxold:"O46empleadospisoextid",gxvar:"A46empleadospisoextid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A46empleadospisoextid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z46empleadospisoextid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("EMPLEADOSPISOEXTID",gx.O.A46empleadospisoextid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A46empleadospisoextid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("EMPLEADOSPISOEXTID",".")},nac:gx.falseFn};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSPISOEXTPISO",gxz:"Z47empleadospisoextpiso",gxold:"O47empleadospisoextpiso",gxvar:"A47empleadospisoextpiso",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A47empleadospisoextpiso=n)},v2z:function(n){n!==undefined&&(gx.O.Z47empleadospisoextpiso=n)},v2c:function(){gx.fn.setControlValue("EMPLEADOSPISOEXTPISO",gx.O.A47empleadospisoextpiso,0)},c2v:function(){this.val()!==undefined&&(gx.O.A47empleadospisoextpiso=this.val())},val:function(){return gx.fn.getControlValue("EMPLEADOSPISOEXTPISO")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"",grid:0};n[30]={lvl:0,type:"svchar",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSPISOEXTEXT",gxz:"Z48empleadospisoextext",gxold:"O48empleadospisoextext",gxvar:"A48empleadospisoextext",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A48empleadospisoextext=n)},v2z:function(n){n!==undefined&&(gx.O.Z48empleadospisoextext=n)},v2c:function(){gx.fn.setControlValue("EMPLEADOSPISOEXTEXT",gx.O.A48empleadospisoextext,0)},c2v:function(){this.val()!==undefined&&(gx.O.A48empleadospisoextext=this.val())},val:function(){return gx.fn.getControlValue("EMPLEADOSPISOEXTEXT")},nac:gx.falseFn};n[31]={fld:"",grid:0};n[32]={fld:"",grid:0};n[33]={fld:"",grid:0};n[34]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSPISOEXTCORREO",gxz:"Z49empleadospisoextcorreo",gxold:"O49empleadospisoextcorreo",gxvar:"A49empleadospisoextcorreo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A49empleadospisoextcorreo=n)},v2z:function(n){n!==undefined&&(gx.O.Z49empleadospisoextcorreo=n)},v2c:function(){gx.fn.setControlValue("EMPLEADOSPISOEXTCORREO",gx.O.A49empleadospisoextcorreo,0)},c2v:function(){this.val()!==undefined&&(gx.O.A49empleadospisoextcorreo=this.val())},val:function(){return gx.fn.getControlValue("EMPLEADOSPISOEXTCORREO")},nac:gx.falseFn};n[35]={fld:"",grid:0};n[36]={fld:"",grid:0};n[37]={fld:"",grid:0};n[38]={lvl:0,type:"int",len:11,dec:0,sign:!1,pic:"ZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOPISOEXTPROFESION",gxz:"Z50empleadopisoextprofesion",gxold:"O50empleadopisoextprofesion",gxvar:"A50empleadopisoextprofesion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A50empleadopisoextprofesion=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z50empleadopisoextprofesion=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("EMPLEADOPISOEXTPROFESION",gx.O.A50empleadopisoextprofesion,0)},c2v:function(){this.val()!==undefined&&(gx.O.A50empleadopisoextprofesion=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("EMPLEADOPISOEXTPROFESION",".")},nac:gx.falseFn};n[39]={fld:"",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSPISOEXTUSUARIO",gxz:"Z51empleadospisoextusuario",gxold:"O51empleadospisoextusuario",gxvar:"A51empleadospisoextusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A51empleadospisoextusuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z51empleadospisoextusuario=n)},v2c:function(){gx.fn.setControlValue("EMPLEADOSPISOEXTUSUARIO",gx.O.A51empleadospisoextusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A51empleadospisoextusuario=this.val())},val:function(){return gx.fn.getControlValue("EMPLEADOSPISOEXTUSUARIO")},nac:gx.falseFn};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"date",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSPISOEXTFECGRE",gxz:"Z52empleadospisoextfecgre",gxold:"O52empleadospisoextfecgre",gxvar:"A52empleadospisoextfecgre",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A52empleadospisoextfecgre=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z52empleadospisoextfecgre=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("EMPLEADOSPISOEXTFECGRE",gx.O.A52empleadospisoextfecgre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A52empleadospisoextfecgre=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("EMPLEADOSPISOEXTFECGRE")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"",grid:0};n[50]={lvl:0,type:"date",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSPISOEXTFEACT",gxz:"Z53empleadospisoextfeact",gxold:"O53empleadospisoextfeact",gxvar:"A53empleadospisoextfeact",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A53empleadospisoextfeact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z53empleadospisoextfeact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("EMPLEADOSPISOEXTFEACT",gx.O.A53empleadospisoextfeact,0)},c2v:function(){this.val()!==undefined&&(gx.O.A53empleadospisoextfeact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("EMPLEADOSPISOEXTFEACT")},nac:gx.falseFn};n[51]={fld:"",grid:0};n[52]={fld:"",grid:0};n[53]={fld:"",grid:0};this.A46empleadospisoextid=0;this.Z46empleadospisoextid=0;this.O46empleadospisoextid=0;this.A47empleadospisoextpiso="";this.Z47empleadospisoextpiso="";this.O47empleadospisoextpiso="";this.A48empleadospisoextext="";this.Z48empleadospisoextext="";this.O48empleadospisoextext="";this.A49empleadospisoextcorreo="";this.Z49empleadospisoextcorreo="";this.O49empleadospisoextcorreo="";this.A50empleadopisoextprofesion=0;this.Z50empleadopisoextprofesion=0;this.O50empleadopisoextprofesion=0;this.A51empleadospisoextusuario="";this.Z51empleadospisoextusuario="";this.O51empleadospisoextusuario="";this.A52empleadospisoextfecgre=gx.date.nullDate();this.Z52empleadospisoextfecgre=gx.date.nullDate();this.O52empleadospisoextfecgre=gx.date.nullDate();this.A53empleadospisoextfeact=gx.date.nullDate();this.Z53empleadospisoextfeact=gx.date.nullDate();this.O53empleadospisoextfeact=gx.date.nullDate();this.AV7empleadospisoextid=0;this.A46empleadospisoextid=0;this.A47empleadospisoextpiso="";this.A48empleadospisoextext="";this.A49empleadospisoextcorreo="";this.A50empleadopisoextprofesion=0;this.A51empleadospisoextusuario="";this.A52empleadospisoextfecgre=gx.date.nullDate();this.A53empleadospisoextfeact=gx.date.nullDate();this.Gx_mode="";this.Events={e110o24_client:["ENTER",!0],e120o24_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0,nv:""},{av:"AV7empleadospisoextid",fld:"vEMPLEADOSPISOEXTID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("AV7empleadospisoextid","vEMPLEADOSPISOEXTID",0,"int");this.setVCMap("Gx_mode","vMODE",0,"char");this.InitStandaloneVars()});gx.createParentObj(empleadospiso)