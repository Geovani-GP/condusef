/**@preserve  GeneXus C# 10_3_15-115824 on 1/26/2022 20:7:20.79
*/
gx.evt.autoSkip=!1;gx.define("estatusarticulo",!1,function(){this.ServerClass="estatusarticulo";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Estatusarticuloid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Estatusarticuloid",["gx.num.urlDecimal(gx.O.A12estatusarticuloid,'.',',')","gx.O.A54estatusarticulodsc","gx.O.A55estatusarticulodescuso","gx.O.A56estatusarticuloaplicamov","gx.O.A57estatusarticulousotabla","gx.O.A58estatusarticulousuario",'gx.date.urlDateTime(gx.O.A59estatusarticulofecreg,"DMY")','gx.date.urlDateTime(gx.O.A60estatusarticulofecultact,"DMY")'],["A54estatusarticulodsc","A55estatusarticulodescuso","A56estatusarticuloaplicamov","A57estatusarticulousotabla","A58estatusarticulousuario","A59estatusarticulofecreg","A60estatusarticulofecultact","Gx_mode","Z12estatusarticuloid","Z54estatusarticulodsc","Z55estatusarticulodescuso","Z56estatusarticuloaplicamov","Z57estatusarticulousotabla","Z58estatusarticulousuario","Z59estatusarticulofecreg","Z60estatusarticulofecultact",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.e11077_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e12077_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,16,17,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53];this.GXLastCtrlId=53;n[2]={fld:"",grid:0};n[3]={fld:"TABLEMAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"TITLE",format:0,grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"",grid:0};n[10]={fld:"",grid:0};n[16]={fld:"",grid:0};n[17]={fld:"",grid:0};n[19]={fld:"",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Estatusarticuloid,isvalid:null,rgrid:[],fld:"ESTATUSARTICULOID",gxz:"Z12estatusarticuloid",gxold:"O12estatusarticuloid",gxvar:"A12estatusarticuloid",ucs:[],op:[50,46,42,38,34,30,26],ip:[50,46,42,38,34,30,26,22],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A12estatusarticuloid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z12estatusarticuloid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ESTATUSARTICULOID",gx.O.A12estatusarticuloid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A12estatusarticuloid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ESTATUSARTICULOID",".")},nac:gx.falseFn};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ESTATUSARTICULODSC",gxz:"Z54estatusarticulodsc",gxold:"O54estatusarticulodsc",gxvar:"A54estatusarticulodsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A54estatusarticulodsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z54estatusarticulodsc=n)},v2c:function(){gx.fn.setControlValue("ESTATUSARTICULODSC",gx.O.A54estatusarticulodsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A54estatusarticulodsc=this.val())},val:function(){return gx.fn.getControlValue("ESTATUSARTICULODSC")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"",grid:0};n[30]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ESTATUSARTICULODESCUSO",gxz:"Z55estatusarticulodescuso",gxold:"O55estatusarticulodescuso",gxvar:"A55estatusarticulodescuso",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A55estatusarticulodescuso=n)},v2z:function(n){n!==undefined&&(gx.O.Z55estatusarticulodescuso=n)},v2c:function(){gx.fn.setControlValue("ESTATUSARTICULODESCUSO",gx.O.A55estatusarticulodescuso,0)},c2v:function(){this.val()!==undefined&&(gx.O.A55estatusarticulodescuso=this.val())},val:function(){return gx.fn.getControlValue("ESTATUSARTICULODESCUSO")},nac:gx.falseFn};n[31]={fld:"",grid:0};n[32]={fld:"",grid:0};n[33]={fld:"",grid:0};n[34]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ESTATUSARTICULOAPLICAMOV",gxz:"Z56estatusarticuloaplicamov",gxold:"O56estatusarticuloaplicamov",gxvar:"A56estatusarticuloaplicamov",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A56estatusarticuloaplicamov=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z56estatusarticuloaplicamov=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ESTATUSARTICULOAPLICAMOV",gx.O.A56estatusarticuloaplicamov,0)},c2v:function(){this.val()!==undefined&&(gx.O.A56estatusarticuloaplicamov=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ESTATUSARTICULOAPLICAMOV",".")},nac:gx.falseFn};n[35]={fld:"",grid:0};n[36]={fld:"",grid:0};n[37]={fld:"",grid:0};n[38]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ESTATUSARTICULOUSOTABLA",gxz:"Z57estatusarticulousotabla",gxold:"O57estatusarticulousotabla",gxvar:"A57estatusarticulousotabla",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A57estatusarticulousotabla=n)},v2z:function(n){n!==undefined&&(gx.O.Z57estatusarticulousotabla=n)},v2c:function(){gx.fn.setControlValue("ESTATUSARTICULOUSOTABLA",gx.O.A57estatusarticulousotabla,0)},c2v:function(){this.val()!==undefined&&(gx.O.A57estatusarticulousotabla=this.val())},val:function(){return gx.fn.getControlValue("ESTATUSARTICULOUSOTABLA")},nac:gx.falseFn};n[39]={fld:"",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ESTATUSARTICULOUSUARIO",gxz:"Z58estatusarticulousuario",gxold:"O58estatusarticulousuario",gxvar:"A58estatusarticulousuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A58estatusarticulousuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z58estatusarticulousuario=n)},v2c:function(){gx.fn.setControlValue("ESTATUSARTICULOUSUARIO",gx.O.A58estatusarticulousuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A58estatusarticulousuario=this.val())},val:function(){return gx.fn.getControlValue("ESTATUSARTICULOUSUARIO")},nac:gx.falseFn};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ESTATUSARTICULOFECREG",gxz:"Z59estatusarticulofecreg",gxold:"O59estatusarticulofecreg",gxvar:"A59estatusarticulofecreg",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A59estatusarticulofecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z59estatusarticulofecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("ESTATUSARTICULOFECREG",gx.O.A59estatusarticulofecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A59estatusarticulofecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("ESTATUSARTICULOFECREG")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"",grid:0};n[50]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ESTATUSARTICULOFECULTACT",gxz:"Z60estatusarticulofecultact",gxold:"O60estatusarticulofecultact",gxvar:"A60estatusarticulofecultact",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A60estatusarticulofecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z60estatusarticulofecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("ESTATUSARTICULOFECULTACT",gx.O.A60estatusarticulofecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.A60estatusarticulofecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("ESTATUSARTICULOFECULTACT")},nac:gx.falseFn};n[51]={fld:"",grid:0};n[52]={fld:"",grid:0};n[53]={fld:"",grid:0};this.A12estatusarticuloid=0;this.Z12estatusarticuloid=0;this.O12estatusarticuloid=0;this.A54estatusarticulodsc="";this.Z54estatusarticulodsc="";this.O54estatusarticulodsc="";this.A55estatusarticulodescuso="";this.Z55estatusarticulodescuso="";this.O55estatusarticulodescuso="";this.A56estatusarticuloaplicamov=0;this.Z56estatusarticuloaplicamov=0;this.O56estatusarticuloaplicamov=0;this.A57estatusarticulousotabla="";this.Z57estatusarticulousotabla="";this.O57estatusarticulousotabla="";this.A58estatusarticulousuario="";this.Z58estatusarticulousuario="";this.O58estatusarticulousuario="";this.A59estatusarticulofecreg=gx.date.nullDate();this.Z59estatusarticulofecreg=gx.date.nullDate();this.O59estatusarticulofecreg=gx.date.nullDate();this.A60estatusarticulofecultact=gx.date.nullDate();this.Z60estatusarticulofecultact=gx.date.nullDate();this.O60estatusarticulofecultact=gx.date.nullDate();this.A12estatusarticuloid=0;this.A54estatusarticulodsc="";this.A55estatusarticulodescuso="";this.A56estatusarticuloaplicamov=0;this.A57estatusarticulousotabla="";this.A58estatusarticulousuario="";this.A59estatusarticulofecreg=gx.date.nullDate();this.A60estatusarticulofecultact=gx.date.nullDate();this.Events={e11077_client:["ENTER",!0],e12077_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char");this.InitStandaloneVars()});gx.createParentObj(estatusarticulo)