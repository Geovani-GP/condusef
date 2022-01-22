/**@preserve  GeneXus C# 10_3_15-115824 on 12/30/2021 22:9:11.22
*/
gx.evt.autoSkip=!1;gx.define("modelos",!1,function(){this.ServerClass="modelos";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Modelosid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Modelosid",["gx.O.A15modelosid","gx.O.A116modelosdsc","gx.O.A117modelosusuario",'gx.date.urlDateTime(gx.O.A118modelosfecreg,"DMY")','gx.date.urlDateTime(gx.O.A119modelosfecultact,"DMY")'],["A116modelosdsc","A117modelosusuario","A118modelosfecreg","A119modelosfecultact","Gx_mode","Z15modelosid","Z116modelosdsc","Z117modelosusuario","Z118modelosfecreg","Z119modelosfecultact",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.Valid_Modelosfecreg=function(){try{var n=gx.util.balloon.getNew("MODELOSFECREG");if(this.AnyError=0,!(new gx.date.gxdate("").compare(this.A118modelosfecreg)==0||new gx.date.gxdate(this.A118modelosfecreg).compare(gx.date.ymdhmstot(1753,01,01,00,00,00))>=0))try{n.setError("Campo modelosfecreg fuera de rango");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Modelosfecultact=function(){try{var n=gx.util.balloon.getNew("MODELOSFECULTACT");if(this.AnyError=0,!(new gx.date.gxdate("").compare(this.A119modelosfecultact)==0||new gx.date.gxdate(this.A119modelosfecultact).compare(gx.date.ymdhmstot(1753,01,01,00,00,00))>=0))try{n.setError("Campo modelosfecultact fuera de rango");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e110j19_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e120j19_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,16,17,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41];this.GXLastCtrlId=41;n[2]={fld:"",grid:0};n[3]={fld:"TABLEMAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"TITLE",format:0,grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"",grid:0};n[10]={fld:"",grid:0};n[16]={fld:"",grid:0};n[17]={fld:"",grid:0};n[19]={fld:"",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Modelosid,isvalid:null,rgrid:[],fld:"MODELOSID",gxz:"Z15modelosid",gxold:"O15modelosid",gxvar:"A15modelosid",ucs:[],op:[38,34,30,26],ip:[38,34,30,26,22],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A15modelosid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z15modelosid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("MODELOSID",gx.O.A15modelosid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A15modelosid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("MODELOSID",".")},nac:gx.falseFn};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"MODELOSDSC",gxz:"Z116modelosdsc",gxold:"O116modelosdsc",gxvar:"A116modelosdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A116modelosdsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z116modelosdsc=n)},v2c:function(){gx.fn.setControlValue("MODELOSDSC",gx.O.A116modelosdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A116modelosdsc=this.val())},val:function(){return gx.fn.getControlValue("MODELOSDSC")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"",grid:0};n[30]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"MODELOSUSUARIO",gxz:"Z117modelosusuario",gxold:"O117modelosusuario",gxvar:"A117modelosusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A117modelosusuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z117modelosusuario=n)},v2c:function(){gx.fn.setControlValue("MODELOSUSUARIO",gx.O.A117modelosusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A117modelosusuario=this.val())},val:function(){return gx.fn.getControlValue("MODELOSUSUARIO")},nac:gx.falseFn};n[31]={fld:"",grid:0};n[32]={fld:"",grid:0};n[33]={fld:"",grid:0};n[34]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Modelosfecreg,isvalid:null,rgrid:[],fld:"MODELOSFECREG",gxz:"Z118modelosfecreg",gxold:"O118modelosfecreg",gxvar:"A118modelosfecreg",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[34],ip:[34],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A118modelosfecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z118modelosfecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("MODELOSFECREG",gx.O.A118modelosfecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A118modelosfecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("MODELOSFECREG")},nac:gx.falseFn};n[35]={fld:"",grid:0};n[36]={fld:"",grid:0};n[37]={fld:"",grid:0};n[38]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Modelosfecultact,isvalid:null,rgrid:[],fld:"MODELOSFECULTACT",gxz:"Z119modelosfecultact",gxold:"O119modelosfecultact",gxvar:"A119modelosfecultact",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[38],ip:[38],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A119modelosfecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z119modelosfecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("MODELOSFECULTACT",gx.O.A119modelosfecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.A119modelosfecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("MODELOSFECULTACT")},nac:gx.falseFn};n[39]={fld:"",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};this.A15modelosid=0;this.Z15modelosid=0;this.O15modelosid=0;this.A116modelosdsc="";this.Z116modelosdsc="";this.O116modelosdsc="";this.A117modelosusuario="";this.Z117modelosusuario="";this.O117modelosusuario="";this.A118modelosfecreg=gx.date.nullDate();this.Z118modelosfecreg=gx.date.nullDate();this.O118modelosfecreg=gx.date.nullDate();this.A119modelosfecultact=gx.date.nullDate();this.Z119modelosfecultact=gx.date.nullDate();this.O119modelosfecultact=gx.date.nullDate();this.A15modelosid=0;this.A116modelosdsc="";this.A117modelosusuario="";this.A118modelosfecreg=gx.date.nullDate();this.A119modelosfecultact=gx.date.nullDate();this.Events={e110j19_client:["ENTER",!0],e120j19_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char");this.InitStandaloneVars()});gx.createParentObj(modelos)