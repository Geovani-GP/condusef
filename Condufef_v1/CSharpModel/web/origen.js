/**@preserve  GeneXus C# 10_3_15-115824 on 1/26/2022 20:7:37.82
*/
gx.evt.autoSkip=!1;gx.define("origen",!1,function(){this.ServerClass="origen";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Origenid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Origenid",["gx.num.urlDecimal(gx.O.A10origenid,'.',',')","gx.O.A120origendscorta","gx.O.A121origendsclarga","gx.O.A122origenusuario","gx.O.A123origentotal",'gx.date.urlDateTime(gx.O.A124origenfecreg,"DMY")','gx.date.urlDateTime(gx.O.A125origenfecultact,"DMY")'],["A120origendscorta","A121origendsclarga","A122origenusuario","A123origentotal","A124origenfecreg","A125origenfecultact","Gx_mode","Z10origenid","Z120origendscorta","Z121origendsclarga","Z122origenusuario","Z123origentotal","Z124origenfecreg","Z125origenfecultact",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.e110g16_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e120g16_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,16,17,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49];this.GXLastCtrlId=49;n[2]={fld:"",grid:0};n[3]={fld:"TABLEMAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"TITLE",format:0,grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"",grid:0};n[10]={fld:"",grid:0};n[16]={fld:"",grid:0};n[17]={fld:"",grid:0};n[19]={fld:"",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Origenid,isvalid:null,rgrid:[],fld:"ORIGENID",gxz:"Z10origenid",gxold:"O10origenid",gxvar:"A10origenid",ucs:[],op:[46,42,38,34,30,26],ip:[46,42,38,34,30,26,22],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A10origenid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z10origenid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ORIGENID",gx.O.A10origenid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A10origenid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ORIGENID",".")},nac:gx.falseFn};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ORIGENDSCORTA",gxz:"Z120origendscorta",gxold:"O120origendscorta",gxvar:"A120origendscorta",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A120origendscorta=n)},v2z:function(n){n!==undefined&&(gx.O.Z120origendscorta=n)},v2c:function(){gx.fn.setControlValue("ORIGENDSCORTA",gx.O.A120origendscorta,0)},c2v:function(){this.val()!==undefined&&(gx.O.A120origendscorta=this.val())},val:function(){return gx.fn.getControlValue("ORIGENDSCORTA")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"",grid:0};n[30]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ORIGENDSCLARGA",gxz:"Z121origendsclarga",gxold:"O121origendsclarga",gxvar:"A121origendsclarga",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A121origendsclarga=n)},v2z:function(n){n!==undefined&&(gx.O.Z121origendsclarga=n)},v2c:function(){gx.fn.setControlValue("ORIGENDSCLARGA",gx.O.A121origendsclarga,0)},c2v:function(){this.val()!==undefined&&(gx.O.A121origendsclarga=this.val())},val:function(){return gx.fn.getControlValue("ORIGENDSCLARGA")},nac:gx.falseFn};n[31]={fld:"",grid:0};n[32]={fld:"",grid:0};n[33]={fld:"",grid:0};n[34]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ORIGENUSUARIO",gxz:"Z122origenusuario",gxold:"O122origenusuario",gxvar:"A122origenusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A122origenusuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z122origenusuario=n)},v2c:function(){gx.fn.setControlValue("ORIGENUSUARIO",gx.O.A122origenusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A122origenusuario=this.val())},val:function(){return gx.fn.getControlValue("ORIGENUSUARIO")},nac:gx.falseFn};n[35]={fld:"",grid:0};n[36]={fld:"",grid:0};n[37]={fld:"",grid:0};n[38]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ORIGENTOTAL",gxz:"Z123origentotal",gxold:"O123origentotal",gxvar:"A123origentotal",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A123origentotal=n)},v2z:function(n){n!==undefined&&(gx.O.Z123origentotal=n)},v2c:function(){gx.fn.setControlValue("ORIGENTOTAL",gx.O.A123origentotal,0)},c2v:function(){this.val()!==undefined&&(gx.O.A123origentotal=this.val())},val:function(){return gx.fn.getControlValue("ORIGENTOTAL")},nac:gx.falseFn};n[39]={fld:"",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ORIGENFECREG",gxz:"Z124origenfecreg",gxold:"O124origenfecreg",gxvar:"A124origenfecreg",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A124origenfecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z124origenfecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("ORIGENFECREG",gx.O.A124origenfecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A124origenfecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("ORIGENFECREG")},nac:gx.falseFn};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ORIGENFECULTACT",gxz:"Z125origenfecultact",gxold:"O125origenfecultact",gxvar:"A125origenfecultact",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A125origenfecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z125origenfecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("ORIGENFECULTACT",gx.O.A125origenfecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.A125origenfecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("ORIGENFECULTACT")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"",grid:0};this.A10origenid=0;this.Z10origenid=0;this.O10origenid=0;this.A120origendscorta="";this.Z120origendscorta="";this.O120origendscorta="";this.A121origendsclarga="";this.Z121origendsclarga="";this.O121origendsclarga="";this.A122origenusuario="";this.Z122origenusuario="";this.O122origenusuario="";this.A123origentotal="";this.Z123origentotal="";this.O123origentotal="";this.A124origenfecreg=gx.date.nullDate();this.Z124origenfecreg=gx.date.nullDate();this.O124origenfecreg=gx.date.nullDate();this.A125origenfecultact=gx.date.nullDate();this.Z125origenfecultact=gx.date.nullDate();this.O125origenfecultact=gx.date.nullDate();this.A10origenid=0;this.A120origendscorta="";this.A121origendsclarga="";this.A122origenusuario="";this.A123origentotal="";this.A124origenfecreg=gx.date.nullDate();this.A125origenfecultact=gx.date.nullDate();this.Events={e110g16_client:["ENTER",!0],e120g16_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char");this.InitStandaloneVars()});gx.createParentObj(origen)