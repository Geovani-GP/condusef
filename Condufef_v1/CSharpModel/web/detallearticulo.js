/**@preserve  GeneXus C# 10_3_15-115824 on 1/30/2022 23:48:25.53
*/
gx.evt.autoSkip=!1;gx.define("detallearticulo",!1,function(){var t,n;this.ServerClass="detallearticulo";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.e132w2_client=function(){this.executeServerEvent("VUPDATEIMAGE.CLICK",!0,arguments[0],!1,!1)};this.e142w2_client=function(){this.executeServerEvent("VDELETEIMAGE.CLICK",!0,arguments[0],!1,!1)};this.e112w2_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e162w2_client=function(){this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,5,7,13,14,15,16,17];this.GXLastCtrlId=17;this.EstatusarticulosgridContainer=new gx.grid.grid(this,2,"WbpLvl2",12,"Estatusarticulosgrid","Estatusarticulosgrid","EstatusarticulosgridContainer",this.CmpContext,this.IsMasterPage,"detallearticulo",[],!1,1,!1,!0,0,!1,!1,!1,"",0,"px","Nueva fila",!1,!1,!1,null,null,!1,"",!1,[1,1,1,1]);n=this.EstatusarticulosgridContainer;n.addSingleLineEdit(12,13,"ESTATUSARTICULOID","estatusarticuloid","","estatusarticuloid","int",0,"px",18,18,"right",null,[],12,"estatusarticuloid",!0,0,!1,!1,"Attribute",1,"");n.addSingleLineEdit(54,14,"ESTATUSARTICULODSC","estatusarticulodsc","","estatusarticulodsc","svchar",0,"px",100,80,"left",null,[],54,"estatusarticulodsc",!0,0,!1,!1,"Attribute",1,"");n.addSingleLineEdit(55,15,"ESTATUSARTICULODESCUSO","estatusarticulodescuso","","estatusarticulodescuso","svchar",0,"px",100,80,"left",null,[],55,"estatusarticulodescuso",!0,0,!1,!1,"Attribute",1,"");n.addBitmap("&Updateimage","vUPDATEIMAGE",16,0,"px",17,"px","e132w2_client","","update Image","Image","");n.addBitmap("&Deleteimage","vDELETEIMAGE",17,0,"px",17,"px","e142w2_client","","delete Image","Image","");this.setGrid(n);t[2]={fld:"TABLE1",grid:0};t[5]={lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.EstatusarticulosgridContainer],fld:"vBUSCAR",gxz:"ZV5buscar",gxold:"OV5buscar",gxvar:"AV5buscar",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV5buscar=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5buscar=n)},v2c:function(){gx.fn.setControlValue("vBUSCAR",gx.O.AV5buscar,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV5buscar=this.val())},val:function(){return gx.fn.getControlValue("vBUSCAR")},nac:gx.falseFn};t[7]={fld:"TEXTBLOCK1",format:0,grid:0};t[13]={lvl:2,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:12,gxgrid:this.EstatusarticulosgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"ESTATUSARTICULOID",gxz:"Z12estatusarticuloid",gxold:"O12estatusarticuloid",gxvar:"A12estatusarticuloid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A12estatusarticuloid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z12estatusarticuloid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ESTATUSARTICULOID",n||gx.fn.currentGridRowImpl(12),gx.O.A12estatusarticuloid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A12estatusarticuloid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ESTATUSARTICULOID",n||gx.fn.currentGridRowImpl(12),".")},nac:gx.falseFn};t[14]={lvl:2,type:"svchar",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:12,gxgrid:this.EstatusarticulosgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"ESTATUSARTICULODSC",gxz:"Z54estatusarticulodsc",gxold:"O54estatusarticulodsc",gxvar:"A54estatusarticulodsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A54estatusarticulodsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z54estatusarticulodsc=n)},v2c:function(n){gx.fn.setGridControlValue("ESTATUSARTICULODSC",n||gx.fn.currentGridRowImpl(12),gx.O.A54estatusarticulodsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A54estatusarticulodsc=this.val())},val:function(n){return gx.fn.getGridControlValue("ESTATUSARTICULODSC",n||gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};t[15]={lvl:2,type:"svchar",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:12,gxgrid:this.EstatusarticulosgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"ESTATUSARTICULODESCUSO",gxz:"Z55estatusarticulodescuso",gxold:"O55estatusarticulodescuso",gxvar:"A55estatusarticulodescuso",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A55estatusarticulodescuso=n)},v2z:function(n){n!==undefined&&(gx.O.Z55estatusarticulodescuso=n)},v2c:function(n){gx.fn.setGridControlValue("ESTATUSARTICULODESCUSO",n||gx.fn.currentGridRowImpl(12),gx.O.A55estatusarticulodescuso,0)},c2v:function(){this.val()!==undefined&&(gx.O.A55estatusarticulodescuso=this.val())},val:function(n){return gx.fn.getGridControlValue("ESTATUSARTICULODESCUSO",n||gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};t[16]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:12,gxgrid:this.EstatusarticulosgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"vUPDATEIMAGE",gxz:"ZV7updateImage",gxold:"OV7updateImage",gxvar:"AV7updateImage",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV7updateImage=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7updateImage=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vUPDATEIMAGE",n||gx.fn.currentGridRowImpl(12),gx.O.AV7updateImage,gx.O.AV10Updateimage_GXI)},c2v:function(){gx.O.AV10Updateimage_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV7updateImage=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATEIMAGE",n||gx.fn.currentGridRowImpl(12))},val_GXI:function(n){return gx.fn.getGridControlValue("vUPDATEIMAGE_GXI",n||gx.fn.currentGridRowImpl(12))},gxvar_GXI:"AV10Updateimage_GXI",nac:gx.falseFn};t[17]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:12,gxgrid:this.EstatusarticulosgridContainer,fnc:null,isvalid:null,rgrid:[],fld:"vDELETEIMAGE",gxz:"ZV6deleteImage",gxold:"OV6deleteImage",gxvar:"AV6deleteImage",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV6deleteImage=n)},v2z:function(n){n!==undefined&&(gx.O.ZV6deleteImage=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vDELETEIMAGE",n||gx.fn.currentGridRowImpl(12),gx.O.AV6deleteImage,gx.O.AV11Deleteimage_GXI)},c2v:function(){gx.O.AV11Deleteimage_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV6deleteImage=this.val())},val:function(n){return gx.fn.getGridControlValue("vDELETEIMAGE",n||gx.fn.currentGridRowImpl(12))},val_GXI:function(n){return gx.fn.getGridControlValue("vDELETEIMAGE_GXI",n||gx.fn.currentGridRowImpl(12))},gxvar_GXI:"AV11Deleteimage_GXI",nac:gx.falseFn};this.AV5buscar="";this.ZV5buscar="";this.OV5buscar="";this.Z12estatusarticuloid=0;this.O12estatusarticuloid=0;this.Z54estatusarticulodsc="";this.O54estatusarticulodsc="";this.Z55estatusarticulodescuso="";this.O55estatusarticulodescuso="";this.ZV7updateImage="";this.OV7updateImage="";this.ZV6deleteImage="";this.OV6deleteImage="";this.AV5buscar="";this.A12estatusarticuloid=0;this.A54estatusarticulodsc="";this.A55estatusarticulodescuso="";this.AV7updateImage="";this.AV6deleteImage="";this.Events={e132w2_client:["VUPDATEIMAGE.CLICK",!0],e142w2_client:["VDELETEIMAGE.CLICK",!0],e112w2_client:["ENTER",!0],e162w2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"ESTATUSARTICULOSGRID_nFirstRecordOnPage",nv:0},{av:"ESTATUSARTICULOSGRID_nEOF",nv:0},{av:"AV5buscar",fld:"vBUSCAR",pic:"",nv:""},{av:"AV7updateImage",fld:"vUPDATEIMAGE",pic:"",nv:""},{av:"AV6deleteImage",fld:"vDELETEIMAGE",pic:"",nv:""}],[]];this.EvtParms["VUPDATEIMAGE.CLICK"]=[[{av:"A12estatusarticuloid",fld:"ESTATUSARTICULOID",pic:"ZZZZZZZZZZZZZZZZZ9",hsh:!0,nv:0}],[]];this.EvtParms["VDELETEIMAGE.CLICK"]=[[{av:"A12estatusarticuloid",fld:"ESTATUSARTICULOID",pic:"ZZZZZZZZZZZZZZZZZ9",hsh:!0,nv:0}],[]];this.EvtParms.ENTER=[[],[]];this.EvtParms["ESTATUSARTICULOSGRID.LOAD"]=[[],[]];this.EnterCtrl=["BUTTON1"];n.addRefreshingVar(this.GXValidFnc[5]);n.addRefreshingVar({rfrVar:"AV7updateImage",rfrProp:"Value",gxAttId:"Updateimage"});n.addRefreshingVar({rfrVar:"AV6deleteImage",rfrProp:"Value",gxAttId:"Deleteimage"});this.InitStandaloneVars()});gx.createParentObj(detallearticulo)