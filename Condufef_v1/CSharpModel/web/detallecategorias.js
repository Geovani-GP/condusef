/**@preserve  GeneXus C# 10_3_15-115824 on 1/30/2022 23:48:24.27
*/
gx.evt.autoSkip=!1;gx.define("detallecategorias",!1,function(){var t,n;this.ServerClass="detallecategorias";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.e132m2_client=function(){this.executeServerEvent("VUPDATEIMAGE.CLICK",!0,arguments[0],!1,!1)};this.e142m2_client=function(){this.executeServerEvent("VDELETEIMAGE.CLICK",!0,arguments[0],!1,!1)};this.e112m2_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e162m2_client=function(){this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,5,7,13,14,15,16];this.GXLastCtrlId=16;this.CategoriasgridContainer=new gx.grid.grid(this,2,"WbpLvl2",12,"Categoriasgrid","Categoriasgrid","CategoriasgridContainer",this.CmpContext,this.IsMasterPage,"detallecategorias",[],!1,1,!1,!0,0,!1,!1,!1,"",0,"px","Nueva fila",!1,!1,!1,null,null,!1,"",!1,[1,1,1,1]);n=this.CategoriasgridContainer;n.addSingleLineEdit(14,13,"CATEGORIASID","categoriasid","","categoriasid","int",0,"px",9,9,"left",null,[],14,"categoriasid",!0,0,!1,!1,"Attribute",1,"");n.addSingleLineEdit(94,14,"CATEGORIASDSC","categoriasdsc","","categoriasdsc","svchar",0,"px",100,80,"left",null,[],94,"categoriasdsc",!0,0,!1,!1,"Attribute",1,"");n.addBitmap("&Updateimage","vUPDATEIMAGE",15,0,"px",17,"px","e132m2_client","","update Image","Image","");n.addBitmap("&Deleteimage","vDELETEIMAGE",16,0,"px",17,"px","e142m2_client","","delete Image","Image","");this.setGrid(n);t[2]={fld:"TABLE1",grid:0};t[5]={lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.CategoriasgridContainer],fld:"vBUSCAR",gxz:"ZV6buscar",gxold:"OV6buscar",gxvar:"AV6buscar",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6buscar=n)},v2z:function(n){n!==undefined&&(gx.O.ZV6buscar=n)},v2c:function(){gx.fn.setControlValue("vBUSCAR",gx.O.AV6buscar,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6buscar=this.val())},val:function(){return gx.fn.getControlValue("vBUSCAR")},nac:gx.falseFn};t[7]={fld:"TEXTBLOCK1",format:0,grid:0};t[13]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:12,gxgrid:this.CategoriasgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"CATEGORIASID",gxz:"Z14categoriasid",gxold:"O14categoriasid",gxvar:"A14categoriasid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A14categoriasid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z14categoriasid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CATEGORIASID",n||gx.fn.currentGridRowImpl(12),gx.O.A14categoriasid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A14categoriasid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("CATEGORIASID",n||gx.fn.currentGridRowImpl(12),".")},nac:gx.falseFn};t[14]={lvl:2,type:"svchar",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:12,gxgrid:this.CategoriasgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"CATEGORIASDSC",gxz:"Z94categoriasdsc",gxold:"O94categoriasdsc",gxvar:"A94categoriasdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A94categoriasdsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z94categoriasdsc=n)},v2c:function(n){gx.fn.setGridControlValue("CATEGORIASDSC",n||gx.fn.currentGridRowImpl(12),gx.O.A94categoriasdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A94categoriasdsc=this.val())},val:function(n){return gx.fn.getGridControlValue("CATEGORIASDSC",n||gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};t[15]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:12,gxgrid:this.CategoriasgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"vUPDATEIMAGE",gxz:"ZV7updateImage",gxold:"OV7updateImage",gxvar:"AV7updateImage",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV7updateImage=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7updateImage=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vUPDATEIMAGE",n||gx.fn.currentGridRowImpl(12),gx.O.AV7updateImage,gx.O.AV10Updateimage_GXI)},c2v:function(){gx.O.AV10Updateimage_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV7updateImage=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATEIMAGE",n||gx.fn.currentGridRowImpl(12))},val_GXI:function(n){return gx.fn.getGridControlValue("vUPDATEIMAGE_GXI",n||gx.fn.currentGridRowImpl(12))},gxvar_GXI:"AV10Updateimage_GXI",nac:gx.falseFn};t[16]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:12,gxgrid:this.CategoriasgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"vDELETEIMAGE",gxz:"ZV5deleteImage",gxold:"OV5deleteImage",gxvar:"AV5deleteImage",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5deleteImage=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5deleteImage=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vDELETEIMAGE",n||gx.fn.currentGridRowImpl(12),gx.O.AV5deleteImage,gx.O.AV11Deleteimage_GXI)},c2v:function(){gx.O.AV11Deleteimage_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5deleteImage=this.val())},val:function(n){return gx.fn.getGridControlValue("vDELETEIMAGE",n||gx.fn.currentGridRowImpl(12))},val_GXI:function(n){return gx.fn.getGridControlValue("vDELETEIMAGE_GXI",n||gx.fn.currentGridRowImpl(12))},gxvar_GXI:"AV11Deleteimage_GXI",nac:gx.falseFn};this.AV6buscar="";this.ZV6buscar="";this.OV6buscar="";this.Z14categoriasid=0;this.O14categoriasid=0;this.Z94categoriasdsc="";this.O94categoriasdsc="";this.ZV7updateImage="";this.OV7updateImage="";this.ZV5deleteImage="";this.OV5deleteImage="";this.AV6buscar="";this.A14categoriasid=0;this.A94categoriasdsc="";this.AV7updateImage="";this.AV5deleteImage="";this.Events={e132m2_client:["VUPDATEIMAGE.CLICK",!0],e142m2_client:["VDELETEIMAGE.CLICK",!0],e112m2_client:["ENTER",!0],e162m2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"CATEGORIASGRID_nFirstRecordOnPage",nv:0},{av:"CATEGORIASGRID_nEOF",nv:0},{av:"AV6buscar",fld:"vBUSCAR",pic:"",nv:""},{av:"AV7updateImage",fld:"vUPDATEIMAGE",pic:"",nv:""},{av:"AV5deleteImage",fld:"vDELETEIMAGE",pic:"",nv:""}],[]];this.EvtParms["VUPDATEIMAGE.CLICK"]=[[{av:"A14categoriasid",fld:"CATEGORIASID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[]];this.EvtParms["VDELETEIMAGE.CLICK"]=[[{av:"A14categoriasid",fld:"CATEGORIASID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[]];this.EvtParms.ENTER=[[],[]];this.EvtParms["CATEGORIASGRID.LOAD"]=[[],[]];this.EnterCtrl=["BUTTON1"];n.addRefreshingVar(this.GXValidFnc[5]);n.addRefreshingVar({rfrVar:"AV7updateImage",rfrProp:"Value",gxAttId:"Updateimage"});n.addRefreshingVar({rfrVar:"AV5deleteImage",rfrProp:"Value",gxAttId:"Deleteimage"});this.InitStandaloneVars()});gx.createParentObj(detallecategorias)