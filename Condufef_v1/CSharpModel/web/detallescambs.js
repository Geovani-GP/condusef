/**@preserve  GeneXus C# 10_3_15-115824 on 2/10/2022 20:2:11.57
*/
gx.evt.autoSkip=!1;gx.define("detallescambs",!1,function(){var t,n;this.ServerClass="detallescambs";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.e142e2_client=function(){this.executeServerEvent("VUPDATEIMAGE.CLICK",!0,arguments[0],!1,!1)};this.e152e2_client=function(){this.executeServerEvent("VDELETEIMAGE.CLICK",!0,arguments[0],!1,!1)};this.e112e2_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e122e2_client=function(){this.executeServerEvent("'IMPRIMIR'",!1,null,!1,!1)};this.e172e2_client=function(){this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,5,7,13,14,15,16];this.GXLastCtrlId=16;this.CambsgridContainer=new gx.grid.grid(this,2,"WbpLvl2",12,"Cambsgrid","Cambsgrid","CambsgridContainer",this.CmpContext,this.IsMasterPage,"detallescambs",[],!1,1,!1,!0,0,!1,!1,!1,"",0,"px","Nueva fila",!1,!1,!1,null,null,!1,"",!1,[1,1,1,1]);n=this.CambsgridContainer;n.addSingleLineEdit(25,13,"CAMBSID","cambsid","","cambsid","int",0,"px",9,9,"left",null,[],25,"cambsid",!0,0,!1,!1,"Attribute",1,"");n.addSingleLineEdit(83,14,"CAMBSDSC","cambsdsc","","cambsdsc","svchar",0,"px",100,80,"left",null,[],83,"cambsdsc",!0,0,!1,!1,"Attribute",1,"");n.addBitmap("&Updateimage","vUPDATEIMAGE",15,41,"px",17,"px","e142e2_client","","","Image","");n.addBitmap("&Deleteimage","vDELETEIMAGE",16,41,"px",17,"px","e152e2_client","","","Image","");this.setGrid(n);t[2]={fld:"TABLE1",grid:0};t[5]={lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.CambsgridContainer],fld:"vBUSCAR",gxz:"ZV6buscar",gxold:"OV6buscar",gxvar:"AV6buscar",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6buscar=n)},v2z:function(n){n!==undefined&&(gx.O.ZV6buscar=n)},v2c:function(){gx.fn.setControlValue("vBUSCAR",gx.O.AV6buscar,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6buscar=this.val())},val:function(){return gx.fn.getControlValue("vBUSCAR")},nac:gx.falseFn};t[7]={fld:"TEXTBLOCK1",format:0,grid:0};t[13]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:12,gxgrid:this.CambsgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"CAMBSID",gxz:"Z25cambsid",gxold:"O25cambsid",gxvar:"A25cambsid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A25cambsid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z25cambsid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CAMBSID",n||gx.fn.currentGridRowImpl(12),gx.O.A25cambsid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A25cambsid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("CAMBSID",n||gx.fn.currentGridRowImpl(12),".")},nac:gx.falseFn};t[14]={lvl:2,type:"svchar",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:12,gxgrid:this.CambsgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"CAMBSDSC",gxz:"Z83cambsdsc",gxold:"O83cambsdsc",gxvar:"A83cambsdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A83cambsdsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z83cambsdsc=n)},v2c:function(n){gx.fn.setGridControlValue("CAMBSDSC",n||gx.fn.currentGridRowImpl(12),gx.O.A83cambsdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A83cambsdsc=this.val())},val:function(n){return gx.fn.getGridControlValue("CAMBSDSC",n||gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};t[15]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:12,gxgrid:this.CambsgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"vUPDATEIMAGE",gxz:"ZV7updateImage",gxold:"OV7updateImage",gxvar:"AV7updateImage",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV7updateImage=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7updateImage=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vUPDATEIMAGE",n||gx.fn.currentGridRowImpl(12),gx.O.AV7updateImage,gx.O.AV11Updateimage_GXI)},c2v:function(){gx.O.AV11Updateimage_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV7updateImage=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATEIMAGE",n||gx.fn.currentGridRowImpl(12))},val_GXI:function(n){return gx.fn.getGridControlValue("vUPDATEIMAGE_GXI",n||gx.fn.currentGridRowImpl(12))},gxvar_GXI:"AV11Updateimage_GXI",nac:gx.falseFn};t[16]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:12,gxgrid:this.CambsgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"vDELETEIMAGE",gxz:"ZV8deleteImage",gxold:"OV8deleteImage",gxvar:"AV8deleteImage",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV8deleteImage=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8deleteImage=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vDELETEIMAGE",n||gx.fn.currentGridRowImpl(12),gx.O.AV8deleteImage,gx.O.AV12Deleteimage_GXI)},c2v:function(){gx.O.AV12Deleteimage_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV8deleteImage=this.val())},val:function(n){return gx.fn.getGridControlValue("vDELETEIMAGE",n||gx.fn.currentGridRowImpl(12))},val_GXI:function(n){return gx.fn.getGridControlValue("vDELETEIMAGE_GXI",n||gx.fn.currentGridRowImpl(12))},gxvar_GXI:"AV12Deleteimage_GXI",nac:gx.falseFn};this.AV6buscar="";this.ZV6buscar="";this.OV6buscar="";this.Z25cambsid=0;this.O25cambsid=0;this.Z83cambsdsc="";this.O83cambsdsc="";this.ZV7updateImage="";this.OV7updateImage="";this.ZV8deleteImage="";this.OV8deleteImage="";this.AV6buscar="";this.A25cambsid=0;this.A83cambsdsc="";this.AV7updateImage="";this.AV8deleteImage="";this.Events={e142e2_client:["VUPDATEIMAGE.CLICK",!0],e152e2_client:["VDELETEIMAGE.CLICK",!0],e112e2_client:["ENTER",!0],e122e2_client:["'IMPRIMIR'",!0],e172e2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"CAMBSGRID_nFirstRecordOnPage",nv:0},{av:"CAMBSGRID_nEOF",nv:0},{av:"AV6buscar",fld:"vBUSCAR",pic:"",nv:""},{av:"AV7updateImage",fld:"vUPDATEIMAGE",pic:"",nv:""},{av:"AV8deleteImage",fld:"vDELETEIMAGE",pic:"",nv:""}],[]];this.EvtParms["VUPDATEIMAGE.CLICK"]=[[{av:"A25cambsid",fld:"CAMBSID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[]];this.EvtParms["VDELETEIMAGE.CLICK"]=[[{av:"A25cambsid",fld:"CAMBSID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[]];this.EvtParms["CAMBSGRID.LOAD"]=[[],[]];this.EvtParms.ENTER=[[],[]];this.EvtParms["'IMPRIMIR'"]=[[],[]];this.EnterCtrl=["BTNAGREGAR"];n.addRefreshingVar(this.GXValidFnc[5]);n.addRefreshingVar({rfrVar:"AV7updateImage",rfrProp:"Value",gxAttId:"Updateimage"});n.addRefreshingVar({rfrVar:"AV8deleteImage",rfrProp:"Value",gxAttId:"Deleteimage"});this.InitStandaloneVars()});gx.createParentObj(detallescambs)