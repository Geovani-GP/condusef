/**@preserve  GeneXus C# 10_3_15-115824 on 1/25/2022 17:34:16.51
*/
gx.evt.autoSkip=!1;gx.define("empleados",!1,function(){this.ServerClass="empleados";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Empleadosid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Empleadosid",["gx.O.A13empleadosid","gx.O.A98empleadosareaid","gx.O.A99empleadosnomemple","gx.O.A100empleadosappaterno","gx.O.A101empleadosapmaterno","gx.O.A102empleadosstatus","gx.O.A103empleadosusuario",'gx.date.urlDateTime(gx.O.A104empleadosfecreg,"DMY")','gx.date.urlDateTime(gx.O.A105empleadosfecultact,"DMY")',"gx.O.A106empleadoscorreo","gx.O.A107empleadosext"],["A98empleadosareaid","A99empleadosnomemple","A100empleadosappaterno","A101empleadosapmaterno","A102empleadosstatus","A103empleadosusuario","A104empleadosfecreg","A105empleadosfecultact","A106empleadoscorreo","A107empleadosext","Gx_mode","Z13empleadosid","Z98empleadosareaid","Z99empleadosnomemple","Z100empleadosappaterno","Z101empleadosapmaterno","Z102empleadosstatus","Z103empleadosusuario","Z104empleadosfecreg","Z105empleadosfecultact","Z106empleadoscorreo","Z107empleadosext",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.e11066_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e12066_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,16,17,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65];this.GXLastCtrlId=65;n[2]={fld:"",grid:0};n[3]={fld:"TABLEMAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"TITLE",format:0,grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"",grid:0};n[10]={fld:"",grid:0};n[16]={fld:"",grid:0};n[17]={fld:"",grid:0};n[19]={fld:"",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Empleadosid,isvalid:null,rgrid:[],fld:"EMPLEADOSID",gxz:"Z13empleadosid",gxold:"O13empleadosid",gxvar:"A13empleadosid",ucs:[],op:[62,58,54,50,46,42,38,34,30,26],ip:[62,58,54,50,46,42,38,34,30,26,22],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A13empleadosid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z13empleadosid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("EMPLEADOSID",gx.O.A13empleadosid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A13empleadosid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("EMPLEADOSID",".")},nac:gx.falseFn};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:3,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSAREAID",gxz:"Z98empleadosareaid",gxold:"O98empleadosareaid",gxvar:"A98empleadosareaid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A98empleadosareaid=n)},v2z:function(n){n!==undefined&&(gx.O.Z98empleadosareaid=n)},v2c:function(){gx.fn.setControlValue("EMPLEADOSAREAID",gx.O.A98empleadosareaid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A98empleadosareaid=this.val())},val:function(){return gx.fn.getControlValue("EMPLEADOSAREAID")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"",grid:0};n[30]={lvl:0,type:"svchar",len:30,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSNOMEMPLE",gxz:"Z99empleadosnomemple",gxold:"O99empleadosnomemple",gxvar:"A99empleadosnomemple",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A99empleadosnomemple=n)},v2z:function(n){n!==undefined&&(gx.O.Z99empleadosnomemple=n)},v2c:function(){gx.fn.setControlValue("EMPLEADOSNOMEMPLE",gx.O.A99empleadosnomemple,0)},c2v:function(){this.val()!==undefined&&(gx.O.A99empleadosnomemple=this.val())},val:function(){return gx.fn.getControlValue("EMPLEADOSNOMEMPLE")},nac:gx.falseFn};n[31]={fld:"",grid:0};n[32]={fld:"",grid:0};n[33]={fld:"",grid:0};n[34]={lvl:0,type:"svchar",len:30,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSAPPATERNO",gxz:"Z100empleadosappaterno",gxold:"O100empleadosappaterno",gxvar:"A100empleadosappaterno",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A100empleadosappaterno=n)},v2z:function(n){n!==undefined&&(gx.O.Z100empleadosappaterno=n)},v2c:function(){gx.fn.setControlValue("EMPLEADOSAPPATERNO",gx.O.A100empleadosappaterno,0)},c2v:function(){this.val()!==undefined&&(gx.O.A100empleadosappaterno=this.val())},val:function(){return gx.fn.getControlValue("EMPLEADOSAPPATERNO")},nac:gx.falseFn};n[35]={fld:"",grid:0};n[36]={fld:"",grid:0};n[37]={fld:"",grid:0};n[38]={lvl:0,type:"svchar",len:30,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSAPMATERNO",gxz:"Z101empleadosapmaterno",gxold:"O101empleadosapmaterno",gxvar:"A101empleadosapmaterno",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A101empleadosapmaterno=n)},v2z:function(n){n!==undefined&&(gx.O.Z101empleadosapmaterno=n)},v2c:function(){gx.fn.setControlValue("EMPLEADOSAPMATERNO",gx.O.A101empleadosapmaterno,0)},c2v:function(){this.val()!==undefined&&(gx.O.A101empleadosapmaterno=this.val())},val:function(){return gx.fn.getControlValue("EMPLEADOSAPMATERNO")},nac:gx.falseFn};n[39]={fld:"",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={lvl:0,type:"svchar",len:1,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSSTATUS",gxz:"Z102empleadosstatus",gxold:"O102empleadosstatus",gxvar:"A102empleadosstatus",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A102empleadosstatus=n)},v2z:function(n){n!==undefined&&(gx.O.Z102empleadosstatus=n)},v2c:function(){gx.fn.setControlValue("EMPLEADOSSTATUS",gx.O.A102empleadosstatus,0)},c2v:function(){this.val()!==undefined&&(gx.O.A102empleadosstatus=this.val())},val:function(){return gx.fn.getControlValue("EMPLEADOSSTATUS")},nac:gx.falseFn};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSUSUARIO",gxz:"Z103empleadosusuario",gxold:"O103empleadosusuario",gxvar:"A103empleadosusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A103empleadosusuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z103empleadosusuario=n)},v2c:function(){gx.fn.setControlValue("EMPLEADOSUSUARIO",gx.O.A103empleadosusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A103empleadosusuario=this.val())},val:function(){return gx.fn.getControlValue("EMPLEADOSUSUARIO")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"",grid:0};n[50]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSFECREG",gxz:"Z104empleadosfecreg",gxold:"O104empleadosfecreg",gxvar:"A104empleadosfecreg",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A104empleadosfecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z104empleadosfecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("EMPLEADOSFECREG",gx.O.A104empleadosfecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A104empleadosfecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("EMPLEADOSFECREG")},nac:gx.falseFn};n[51]={fld:"",grid:0};n[52]={fld:"",grid:0};n[53]={fld:"",grid:0};n[54]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSFECULTACT",gxz:"Z105empleadosfecultact",gxold:"O105empleadosfecultact",gxvar:"A105empleadosfecultact",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A105empleadosfecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z105empleadosfecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("EMPLEADOSFECULTACT",gx.O.A105empleadosfecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.A105empleadosfecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("EMPLEADOSFECULTACT")},nac:gx.falseFn};n[55]={fld:"",grid:0};n[56]={fld:"",grid:0};n[57]={fld:"",grid:0};n[58]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSCORREO",gxz:"Z106empleadoscorreo",gxold:"O106empleadoscorreo",gxvar:"A106empleadoscorreo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A106empleadoscorreo=n)},v2z:function(n){n!==undefined&&(gx.O.Z106empleadoscorreo=n)},v2c:function(){gx.fn.setControlValue("EMPLEADOSCORREO",gx.O.A106empleadoscorreo,0)},c2v:function(){this.val()!==undefined&&(gx.O.A106empleadoscorreo=this.val())},val:function(){return gx.fn.getControlValue("EMPLEADOSCORREO")},nac:gx.falseFn};n[59]={fld:"",grid:0};n[60]={fld:"",grid:0};n[61]={fld:"",grid:0};n[62]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"EMPLEADOSEXT",gxz:"Z107empleadosext",gxold:"O107empleadosext",gxvar:"A107empleadosext",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A107empleadosext=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z107empleadosext=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("EMPLEADOSEXT",gx.O.A107empleadosext,0)},c2v:function(){this.val()!==undefined&&(gx.O.A107empleadosext=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("EMPLEADOSEXT",".")},nac:gx.falseFn};n[63]={fld:"",grid:0};n[64]={fld:"",grid:0};n[65]={fld:"",grid:0};this.A13empleadosid=0;this.Z13empleadosid=0;this.O13empleadosid=0;this.A98empleadosareaid="";this.Z98empleadosareaid="";this.O98empleadosareaid="";this.A99empleadosnomemple="";this.Z99empleadosnomemple="";this.O99empleadosnomemple="";this.A100empleadosappaterno="";this.Z100empleadosappaterno="";this.O100empleadosappaterno="";this.A101empleadosapmaterno="";this.Z101empleadosapmaterno="";this.O101empleadosapmaterno="";this.A102empleadosstatus="";this.Z102empleadosstatus="";this.O102empleadosstatus="";this.A103empleadosusuario="";this.Z103empleadosusuario="";this.O103empleadosusuario="";this.A104empleadosfecreg=gx.date.nullDate();this.Z104empleadosfecreg=gx.date.nullDate();this.O104empleadosfecreg=gx.date.nullDate();this.A105empleadosfecultact=gx.date.nullDate();this.Z105empleadosfecultact=gx.date.nullDate();this.O105empleadosfecultact=gx.date.nullDate();this.A106empleadoscorreo="";this.Z106empleadoscorreo="";this.O106empleadoscorreo="";this.A107empleadosext=0;this.Z107empleadosext=0;this.O107empleadosext=0;this.A13empleadosid=0;this.A98empleadosareaid="";this.A99empleadosnomemple="";this.A100empleadosappaterno="";this.A101empleadosapmaterno="";this.A102empleadosstatus="";this.A103empleadosusuario="";this.A104empleadosfecreg=gx.date.nullDate();this.A105empleadosfecultact=gx.date.nullDate();this.A106empleadoscorreo="";this.A107empleadosext=0;this.Events={e11066_client:["ENTER",!0],e12066_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char");this.InitStandaloneVars()});gx.createParentObj(empleados)