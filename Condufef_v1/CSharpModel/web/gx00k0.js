/**@preserve  GeneXus C# 10_3_15-115824 on 1/28/2022 1:41:39.85
*/
gx.evt.autoSkip=!1;gx.define("gx00k0",!1,function(){var n,t;this.ServerClass="gx00k0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV11ptipodocumentoid=gx.fn.getIntegerValue("vPTIPODOCUMENTOID",".")};this.e16291_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle"));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}])};this.e11291_client=function(){this.clearMessages();gx.fn.getCtrlProperty("TIPODOCUMENTOIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("TIPODOCUMENTOIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCTIPODOCUMENTOID","Visible",!0)):(gx.fn.setCtrlProperty("TIPODOCUMENTOIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCTIPODOCUMENTOID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("TIPODOCUMENTOIDFILTERCONTAINER","Class")',ctrl:"TIPODOCUMENTOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTIPODOCUMENTOID","Visible")',ctrl:"vCTIPODOCUMENTOID",prop:"Visible"}])};this.e12291_client=function(){this.clearMessages();gx.fn.getCtrlProperty("TIPODOCUMENTODSCFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("TIPODOCUMENTODSCFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCTIPODOCUMENTODSC","Visible",!0)):(gx.fn.setCtrlProperty("TIPODOCUMENTODSCFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCTIPODOCUMENTODSC","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("TIPODOCUMENTODSCFILTERCONTAINER","Class")',ctrl:"TIPODOCUMENTODSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTIPODOCUMENTODSC","Visible")',ctrl:"vCTIPODOCUMENTODSC",prop:"Visible"}])};this.e13291_client=function(){this.clearMessages();gx.fn.getCtrlProperty("TIPODOCUMENTOUSUARIOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("TIPODOCUMENTOUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCTIPODOCUMENTOUSUARIO","Visible",!0)):(gx.fn.setCtrlProperty("TIPODOCUMENTOUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCTIPODOCUMENTOUSUARIO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("TIPODOCUMENTOUSUARIOFILTERCONTAINER","Class")',ctrl:"TIPODOCUMENTOUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTIPODOCUMENTOUSUARIO","Visible")',ctrl:"vCTIPODOCUMENTOUSUARIO",prop:"Visible"}])};this.e14291_client=function(){this.clearMessages();gx.fn.getCtrlProperty("TIPODOCUMENTOFECREGFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("TIPODOCUMENTOFECREGFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("TIPODOCUMENTOFECREGFILTERCONTAINER","Class","AdvancedContainerItem");this.refreshOutputs([{av:'gx.fn.getCtrlProperty("TIPODOCUMENTOFECREGFILTERCONTAINER","Class")',ctrl:"TIPODOCUMENTOFECREGFILTERCONTAINER",prop:"Class"}])};this.e15291_client=function(){this.clearMessages();gx.fn.getCtrlProperty("TIPODOCUMENTOFECULTACTFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("TIPODOCUMENTOFECULTACTFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("TIPODOCUMENTOFECULTACTFILTERCONTAINER","Class","AdvancedContainerItem");this.refreshOutputs([{av:'gx.fn.getCtrlProperty("TIPODOCUMENTOFECULTACTFILTERCONTAINER","Class")',ctrl:"TIPODOCUMENTOFECULTACTFILTERCONTAINER",prop:"Class"}])};this.e19292_client=function(){this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e20291_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,62,63,65,66,67,68,69];this.GXLastCtrlId=69;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",64,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00k0",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",65,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(26,66,"TIPODOCUMENTOID","tipodocumentoid","","tipodocumentoid","int",0,"px",9,9,"right",null,[],26,"tipodocumentoid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(79,67,"TIPODOCUMENTODSC","tipodocumentodsc","","tipodocumentodsc","svchar",0,"px",100,80,"left",null,[],79,"tipodocumentodsc",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");this.setGrid(t);n[2]={fld:"",grid:0};n[3]={fld:"MAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"ADVANCEDCONTAINER",grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"TIPODOCUMENTOIDFILTERCONTAINER",grid:0};n[10]={fld:"",grid:0};n[11]={fld:"",grid:0};n[12]={fld:"LBLTIPODOCUMENTOIDFILTER",format:1,grid:0};n[13]={fld:"",grid:0};n[14]={fld:"",grid:0};n[15]={fld:"",grid:0};n[16]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCTIPODOCUMENTOID",gxz:"ZV6ctipodocumentoid",gxold:"OV6ctipodocumentoid",gxvar:"AV6ctipodocumentoid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6ctipodocumentoid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6ctipodocumentoid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCTIPODOCUMENTOID",gx.O.AV6ctipodocumentoid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6ctipodocumentoid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCTIPODOCUMENTOID",".")},nac:gx.falseFn};n[17]={fld:"",grid:0};n[18]={fld:"",grid:0};n[19]={fld:"TIPODOCUMENTODSCFILTERCONTAINER",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={fld:"LBLTIPODOCUMENTODSCFILTER",format:1,grid:0};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCTIPODOCUMENTODSC",gxz:"ZV7ctipodocumentodsc",gxold:"OV7ctipodocumentodsc",gxvar:"AV7ctipodocumentodsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7ctipodocumentodsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7ctipodocumentodsc=n)},v2c:function(){gx.fn.setControlValue("vCTIPODOCUMENTODSC",gx.O.AV7ctipodocumentodsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7ctipodocumentodsc=this.val())},val:function(){return gx.fn.getControlValue("vCTIPODOCUMENTODSC")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"TIPODOCUMENTOUSUARIOFILTERCONTAINER",grid:0};n[30]={fld:"",grid:0};n[31]={fld:"",grid:0};n[32]={fld:"LBLTIPODOCUMENTOUSUARIOFILTER",format:1,grid:0};n[33]={fld:"",grid:0};n[34]={fld:"",grid:0};n[35]={fld:"",grid:0};n[36]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCTIPODOCUMENTOUSUARIO",gxz:"ZV8ctipodocumentousuario",gxold:"OV8ctipodocumentousuario",gxvar:"AV8ctipodocumentousuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8ctipodocumentousuario=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8ctipodocumentousuario=n)},v2c:function(){gx.fn.setControlValue("vCTIPODOCUMENTOUSUARIO",gx.O.AV8ctipodocumentousuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8ctipodocumentousuario=this.val())},val:function(){return gx.fn.getControlValue("vCTIPODOCUMENTOUSUARIO")},nac:gx.falseFn};n[37]={fld:"",grid:0};n[38]={fld:"",grid:0};n[39]={fld:"TIPODOCUMENTOFECREGFILTERCONTAINER",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={fld:"LBLTIPODOCUMENTOFECREGFILTER",format:1,grid:0};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCTIPODOCUMENTOFECREG",gxz:"ZV9ctipodocumentofecreg",gxold:"OV9ctipodocumentofecreg",gxvar:"AV9ctipodocumentofecreg",dp:{f:-1,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9ctipodocumentofecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV9ctipodocumentofecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCTIPODOCUMENTOFECREG",gx.O.AV9ctipodocumentofecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9ctipodocumentofecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vCTIPODOCUMENTOFECREG")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"TIPODOCUMENTOFECULTACTFILTERCONTAINER",grid:0};n[50]={fld:"",grid:0};n[51]={fld:"",grid:0};n[52]={fld:"LBLTIPODOCUMENTOFECULTACTFILTER",format:1,grid:0};n[53]={fld:"",grid:0};n[54]={fld:"",grid:0};n[55]={fld:"",grid:0};n[56]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCTIPODOCUMENTOFECULTACT",gxz:"ZV10ctipodocumentofecultact",gxold:"OV10ctipodocumentofecultact",gxvar:"AV10ctipodocumentofecultact",dp:{f:-1,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10ctipodocumentofecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV10ctipodocumentofecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCTIPODOCUMENTOFECULTACT",gx.O.AV10ctipodocumentofecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10ctipodocumentofecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vCTIPODOCUMENTOFECULTACT")},nac:gx.falseFn};n[57]={fld:"",grid:0};n[58]={fld:"GRIDTABLE",grid:0};n[59]={fld:"",grid:0};n[60]={fld:"",grid:0};n[62]={fld:"",grid:0};n[63]={fld:"",grid:0};n[65]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64),gx.O.AV5LinkSelection,gx.O.AV15Linkselection_GXI)},c2v:function(){gx.O.AV15Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(64))},gxvar_GXI:"AV15Linkselection_GXI",nac:gx.falseFn};n[66]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"TIPODOCUMENTOID",gxz:"Z26tipodocumentoid",gxold:"O26tipodocumentoid",gxvar:"A26tipodocumentoid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A26tipodocumentoid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z26tipodocumentoid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("TIPODOCUMENTOID",n||gx.fn.currentGridRowImpl(64),gx.O.A26tipodocumentoid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A26tipodocumentoid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("TIPODOCUMENTOID",n||gx.fn.currentGridRowImpl(64),".")},nac:gx.falseFn};n[67]={lvl:2,type:"svchar",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"TIPODOCUMENTODSC",gxz:"Z79tipodocumentodsc",gxold:"O79tipodocumentodsc",gxvar:"A79tipodocumentodsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A79tipodocumentodsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z79tipodocumentodsc=n)},v2c:function(n){gx.fn.setGridControlValue("TIPODOCUMENTODSC",n||gx.fn.currentGridRowImpl(64),gx.O.A79tipodocumentodsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A79tipodocumentodsc=this.val())},val:function(n){return gx.fn.getGridControlValue("TIPODOCUMENTODSC",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[68]={fld:"",grid:0};n[69]={fld:"",grid:0};this.AV6ctipodocumentoid=0;this.ZV6ctipodocumentoid=0;this.OV6ctipodocumentoid=0;this.AV7ctipodocumentodsc="";this.ZV7ctipodocumentodsc="";this.OV7ctipodocumentodsc="";this.AV8ctipodocumentousuario="";this.ZV8ctipodocumentousuario="";this.OV8ctipodocumentousuario="";this.AV9ctipodocumentofecreg=gx.date.nullDate();this.ZV9ctipodocumentofecreg=gx.date.nullDate();this.OV9ctipodocumentofecreg=gx.date.nullDate();this.AV10ctipodocumentofecultact=gx.date.nullDate();this.ZV10ctipodocumentofecultact=gx.date.nullDate();this.OV10ctipodocumentofecultact=gx.date.nullDate();this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z26tipodocumentoid=0;this.O26tipodocumentoid=0;this.Z79tipodocumentodsc="";this.O79tipodocumentodsc="";this.AV6ctipodocumentoid=0;this.AV7ctipodocumentodsc="";this.AV8ctipodocumentousuario="";this.AV9ctipodocumentofecreg=gx.date.nullDate();this.AV10ctipodocumentofecultact=gx.date.nullDate();this.AV11ptipodocumentoid=0;this.A82tipodocumentofecultact=gx.date.nullDate();this.A81tipodocumentofecreg=gx.date.nullDate();this.A80tipodocumentousuario="";this.AV5LinkSelection="";this.A26tipodocumentoid=0;this.A79tipodocumentodsc="";this.Events={e19292_client:["ENTER",!0],e20291_client:["CANCEL",!0],e16291_client:["'TOGGLE'",!1],e11291_client:["LBLTIPODOCUMENTOIDFILTER.CLICK",!1],e12291_client:["LBLTIPODOCUMENTODSCFILTER.CLICK",!1],e13291_client:["LBLTIPODOCUMENTOUSUARIOFILTER.CLICK",!1],e14291_client:["LBLTIPODOCUMENTOFECREGFILTER.CLICK",!1],e15291_client:["LBLTIPODOCUMENTOFECULTACTFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6ctipodocumentoid",fld:"vCTIPODOCUMENTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7ctipodocumentodsc",fld:"vCTIPODOCUMENTODSC",pic:"",nv:""},{av:"AV8ctipodocumentousuario",fld:"vCTIPODOCUMENTOUSUARIO",pic:"",nv:""},{av:"AV9ctipodocumentofecreg",fld:"vCTIPODOCUMENTOFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10ctipodocumentofecultact",fld:"vCTIPODOCUMENTOFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLTIPODOCUMENTOIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("TIPODOCUMENTOIDFILTERCONTAINER","Class")',ctrl:"TIPODOCUMENTOIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("TIPODOCUMENTOIDFILTERCONTAINER","Class")',ctrl:"TIPODOCUMENTOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTIPODOCUMENTOID","Visible")',ctrl:"vCTIPODOCUMENTOID",prop:"Visible"}]];this.EvtParms["LBLTIPODOCUMENTODSCFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("TIPODOCUMENTODSCFILTERCONTAINER","Class")',ctrl:"TIPODOCUMENTODSCFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("TIPODOCUMENTODSCFILTERCONTAINER","Class")',ctrl:"TIPODOCUMENTODSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTIPODOCUMENTODSC","Visible")',ctrl:"vCTIPODOCUMENTODSC",prop:"Visible"}]];this.EvtParms["LBLTIPODOCUMENTOUSUARIOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("TIPODOCUMENTOUSUARIOFILTERCONTAINER","Class")',ctrl:"TIPODOCUMENTOUSUARIOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("TIPODOCUMENTOUSUARIOFILTERCONTAINER","Class")',ctrl:"TIPODOCUMENTOUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTIPODOCUMENTOUSUARIO","Visible")',ctrl:"vCTIPODOCUMENTOUSUARIO",prop:"Visible"}]];this.EvtParms["LBLTIPODOCUMENTOFECREGFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("TIPODOCUMENTOFECREGFILTERCONTAINER","Class")',ctrl:"TIPODOCUMENTOFECREGFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("TIPODOCUMENTOFECREGFILTERCONTAINER","Class")',ctrl:"TIPODOCUMENTOFECREGFILTERCONTAINER",prop:"Class"}]];this.EvtParms["LBLTIPODOCUMENTOFECULTACTFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("TIPODOCUMENTOFECULTACTFILTERCONTAINER","Class")',ctrl:"TIPODOCUMENTOFECULTACTFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("TIPODOCUMENTOFECULTACTFILTERCONTAINER","Class")',ctrl:"TIPODOCUMENTOFECULTACTFILTERCONTAINER",prop:"Class"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A26tipodocumentoid",fld:"TIPODOCUMENTOID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV11ptipodocumentoid",fld:"vPTIPODOCUMENTOID",pic:"ZZZZZZZZ9",nv:0}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6ctipodocumentoid",fld:"vCTIPODOCUMENTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7ctipodocumentodsc",fld:"vCTIPODOCUMENTODSC",pic:"",nv:""},{av:"AV8ctipodocumentousuario",fld:"vCTIPODOCUMENTOUSUARIO",pic:"",nv:""},{av:"AV9ctipodocumentofecreg",fld:"vCTIPODOCUMENTOFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10ctipodocumentofecultact",fld:"vCTIPODOCUMENTOFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6ctipodocumentoid",fld:"vCTIPODOCUMENTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7ctipodocumentodsc",fld:"vCTIPODOCUMENTODSC",pic:"",nv:""},{av:"AV8ctipodocumentousuario",fld:"vCTIPODOCUMENTOUSUARIO",pic:"",nv:""},{av:"AV9ctipodocumentofecreg",fld:"vCTIPODOCUMENTOFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10ctipodocumentofecultact",fld:"vCTIPODOCUMENTOFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6ctipodocumentoid",fld:"vCTIPODOCUMENTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7ctipodocumentodsc",fld:"vCTIPODOCUMENTODSC",pic:"",nv:""},{av:"AV8ctipodocumentousuario",fld:"vCTIPODOCUMENTOUSUARIO",pic:"",nv:""},{av:"AV9ctipodocumentofecreg",fld:"vCTIPODOCUMENTOFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10ctipodocumentofecultact",fld:"vCTIPODOCUMENTOFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6ctipodocumentoid",fld:"vCTIPODOCUMENTOID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7ctipodocumentodsc",fld:"vCTIPODOCUMENTODSC",pic:"",nv:""},{av:"AV8ctipodocumentousuario",fld:"vCTIPODOCUMENTOUSUARIO",pic:"",nv:""},{av:"AV9ctipodocumentofecreg",fld:"vCTIPODOCUMENTOFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10ctipodocumentofecultact",fld:"vCTIPODOCUMENTOFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.setVCMap("AV11ptipodocumentoid","vPTIPODOCUMENTOID",0,"int");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);this.InitStandaloneVars()});gx.createParentObj(gx00k0)