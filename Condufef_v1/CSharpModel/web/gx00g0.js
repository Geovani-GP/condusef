/**@preserve  GeneXus C# 10_3_15-115824 on 1/22/2022 13:28:6.3
*/
gx.evt.autoSkip=!1;gx.define("gx00g0",!1,function(){var n,t;this.ServerClass="gx00g0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV13porigenid=gx.fn.getIntegerValue("vPORIGENID",".")};this.e180k1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle"));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}])};this.e110k1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ORIGENIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ORIGENIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCORIGENID","Visible",!0)):(gx.fn.setCtrlProperty("ORIGENIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCORIGENID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ORIGENIDFILTERCONTAINER","Class")',ctrl:"ORIGENIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCORIGENID","Visible")',ctrl:"vCORIGENID",prop:"Visible"}])};this.e120k1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ORIGENDSCORTAFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ORIGENDSCORTAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCORIGENDSCORTA","Visible",!0)):(gx.fn.setCtrlProperty("ORIGENDSCORTAFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCORIGENDSCORTA","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ORIGENDSCORTAFILTERCONTAINER","Class")',ctrl:"ORIGENDSCORTAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCORIGENDSCORTA","Visible")',ctrl:"vCORIGENDSCORTA",prop:"Visible"}])};this.e130k1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ORIGENDSCLARGAFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ORIGENDSCLARGAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCORIGENDSCLARGA","Visible",!0)):(gx.fn.setCtrlProperty("ORIGENDSCLARGAFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCORIGENDSCLARGA","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ORIGENDSCLARGAFILTERCONTAINER","Class")',ctrl:"ORIGENDSCLARGAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCORIGENDSCLARGA","Visible")',ctrl:"vCORIGENDSCLARGA",prop:"Visible"}])};this.e140k1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ORIGENUSUARIOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ORIGENUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCORIGENUSUARIO","Visible",!0)):(gx.fn.setCtrlProperty("ORIGENUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCORIGENUSUARIO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ORIGENUSUARIOFILTERCONTAINER","Class")',ctrl:"ORIGENUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCORIGENUSUARIO","Visible")',ctrl:"vCORIGENUSUARIO",prop:"Visible"}])};this.e150k1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ORIGENTOTALFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ORIGENTOTALFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCORIGENTOTAL","Visible",!0)):(gx.fn.setCtrlProperty("ORIGENTOTALFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCORIGENTOTAL","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ORIGENTOTALFILTERCONTAINER","Class")',ctrl:"ORIGENTOTALFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCORIGENTOTAL","Visible")',ctrl:"vCORIGENTOTAL",prop:"Visible"}])};this.e160k1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ORIGENFECREGFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("ORIGENFECREGFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("ORIGENFECREGFILTERCONTAINER","Class","AdvancedContainerItem");this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ORIGENFECREGFILTERCONTAINER","Class")',ctrl:"ORIGENFECREGFILTERCONTAINER",prop:"Class"}])};this.e170k1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ORIGENFECULTACTFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("ORIGENFECULTACTFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("ORIGENFECULTACTFILTERCONTAINER","Class","AdvancedContainerItem");this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ORIGENFECULTACTFILTERCONTAINER","Class")',ctrl:"ORIGENFECULTACTFILTERCONTAINER",prop:"Class"}])};this.e210k2_client=function(){this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e220k1_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,82,83,85,86,87,88,89,90,91,92];this.GXLastCtrlId=92;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",84,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00g0",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",85,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(10,86,"ORIGENID","origenid","","origenid","int",0,"px",18,18,"right",null,[],10,"origenid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(120,87,"ORIGENDSCORTA","origendscorta","","origendscorta","svchar",0,"px",50,50,"left",null,[],120,"origendscorta",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(122,88,"ORIGENUSUARIO","origenusuario","","origenusuario","svchar",0,"px",15,15,"left",null,[],122,"origenusuario",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(124,89,"ORIGENFECREG","origenfecreg","","origenfecreg","dtime",0,"px",19,19,"right",null,[],124,"origenfecreg",!0,8,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(125,90,"ORIGENFECULTACT","origenfecultact","","origenfecultact","dtime",0,"px",19,19,"right",null,[],125,"origenfecultact",!0,8,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.setGrid(t);n[2]={fld:"",grid:0};n[3]={fld:"MAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"ADVANCEDCONTAINER",grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"ORIGENIDFILTERCONTAINER",grid:0};n[10]={fld:"",grid:0};n[11]={fld:"",grid:0};n[12]={fld:"LBLORIGENIDFILTER",format:1,grid:0};n[13]={fld:"",grid:0};n[14]={fld:"",grid:0};n[15]={fld:"",grid:0};n[16]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCORIGENID",gxz:"ZV6corigenid",gxold:"OV6corigenid",gxvar:"AV6corigenid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6corigenid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6corigenid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCORIGENID",gx.O.AV6corigenid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6corigenid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCORIGENID",".")},nac:gx.falseFn};n[17]={fld:"",grid:0};n[18]={fld:"",grid:0};n[19]={fld:"ORIGENDSCORTAFILTERCONTAINER",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={fld:"LBLORIGENDSCORTAFILTER",format:1,grid:0};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCORIGENDSCORTA",gxz:"ZV7corigendscorta",gxold:"OV7corigendscorta",gxvar:"AV7corigendscorta",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7corigendscorta=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7corigendscorta=n)},v2c:function(){gx.fn.setControlValue("vCORIGENDSCORTA",gx.O.AV7corigendscorta,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7corigendscorta=this.val())},val:function(){return gx.fn.getControlValue("vCORIGENDSCORTA")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"ORIGENDSCLARGAFILTERCONTAINER",grid:0};n[30]={fld:"",grid:0};n[31]={fld:"",grid:0};n[32]={fld:"LBLORIGENDSCLARGAFILTER",format:1,grid:0};n[33]={fld:"",grid:0};n[34]={fld:"",grid:0};n[35]={fld:"",grid:0};n[36]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCORIGENDSCLARGA",gxz:"ZV8corigendsclarga",gxold:"OV8corigendsclarga",gxvar:"AV8corigendsclarga",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8corigendsclarga=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8corigendsclarga=n)},v2c:function(){gx.fn.setControlValue("vCORIGENDSCLARGA",gx.O.AV8corigendsclarga,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8corigendsclarga=this.val())},val:function(){return gx.fn.getControlValue("vCORIGENDSCLARGA")},nac:gx.falseFn};n[37]={fld:"",grid:0};n[38]={fld:"",grid:0};n[39]={fld:"ORIGENUSUARIOFILTERCONTAINER",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={fld:"LBLORIGENUSUARIOFILTER",format:1,grid:0};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCORIGENUSUARIO",gxz:"ZV9corigenusuario",gxold:"OV9corigenusuario",gxvar:"AV9corigenusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9corigenusuario=n)},v2z:function(n){n!==undefined&&(gx.O.ZV9corigenusuario=n)},v2c:function(){gx.fn.setControlValue("vCORIGENUSUARIO",gx.O.AV9corigenusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9corigenusuario=this.val())},val:function(){return gx.fn.getControlValue("vCORIGENUSUARIO")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"ORIGENTOTALFILTERCONTAINER",grid:0};n[50]={fld:"",grid:0};n[51]={fld:"",grid:0};n[52]={fld:"LBLORIGENTOTALFILTER",format:1,grid:0};n[53]={fld:"",grid:0};n[54]={fld:"",grid:0};n[55]={fld:"",grid:0};n[56]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCORIGENTOTAL",gxz:"ZV10corigentotal",gxold:"OV10corigentotal",gxvar:"AV10corigentotal",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10corigentotal=n)},v2z:function(n){n!==undefined&&(gx.O.ZV10corigentotal=n)},v2c:function(){gx.fn.setControlValue("vCORIGENTOTAL",gx.O.AV10corigentotal,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10corigentotal=this.val())},val:function(){return gx.fn.getControlValue("vCORIGENTOTAL")},nac:gx.falseFn};n[57]={fld:"",grid:0};n[58]={fld:"",grid:0};n[59]={fld:"ORIGENFECREGFILTERCONTAINER",grid:0};n[60]={fld:"",grid:0};n[61]={fld:"",grid:0};n[62]={fld:"LBLORIGENFECREGFILTER",format:1,grid:0};n[63]={fld:"",grid:0};n[64]={fld:"",grid:0};n[65]={fld:"",grid:0};n[66]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCORIGENFECREG",gxz:"ZV11corigenfecreg",gxold:"OV11corigenfecreg",gxvar:"AV11corigenfecreg",dp:{f:-1,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11corigenfecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV11corigenfecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCORIGENFECREG",gx.O.AV11corigenfecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11corigenfecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vCORIGENFECREG")},nac:gx.falseFn};n[67]={fld:"",grid:0};n[68]={fld:"",grid:0};n[69]={fld:"ORIGENFECULTACTFILTERCONTAINER",grid:0};n[70]={fld:"",grid:0};n[71]={fld:"",grid:0};n[72]={fld:"LBLORIGENFECULTACTFILTER",format:1,grid:0};n[73]={fld:"",grid:0};n[74]={fld:"",grid:0};n[75]={fld:"",grid:0};n[76]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCORIGENFECULTACT",gxz:"ZV12corigenfecultact",gxold:"OV12corigenfecultact",gxvar:"AV12corigenfecultact",dp:{f:-1,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV12corigenfecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV12corigenfecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCORIGENFECULTACT",gx.O.AV12corigenfecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV12corigenfecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vCORIGENFECULTACT")},nac:gx.falseFn};n[77]={fld:"",grid:0};n[78]={fld:"GRIDTABLE",grid:0};n[79]={fld:"",grid:0};n[80]={fld:"",grid:0};n[82]={fld:"",grid:0};n[83]={fld:"",grid:0};n[85]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84),gx.O.AV5LinkSelection,gx.O.AV17Linkselection_GXI)},c2v:function(){gx.O.AV17Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(84))},gxvar_GXI:"AV17Linkselection_GXI",nac:gx.falseFn};n[86]={lvl:2,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ORIGENID",gxz:"Z10origenid",gxold:"O10origenid",gxvar:"A10origenid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A10origenid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z10origenid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ORIGENID",n||gx.fn.currentGridRowImpl(84),gx.O.A10origenid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A10origenid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ORIGENID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[87]={lvl:2,type:"svchar",len:50,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ORIGENDSCORTA",gxz:"Z120origendscorta",gxold:"O120origendscorta",gxvar:"A120origendscorta",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A120origendscorta=n)},v2z:function(n){n!==undefined&&(gx.O.Z120origendscorta=n)},v2c:function(n){gx.fn.setGridControlValue("ORIGENDSCORTA",n||gx.fn.currentGridRowImpl(84),gx.O.A120origendscorta,0)},c2v:function(){this.val()!==undefined&&(gx.O.A120origendscorta=this.val())},val:function(n){return gx.fn.getGridControlValue("ORIGENDSCORTA",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[88]={lvl:2,type:"svchar",len:15,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ORIGENUSUARIO",gxz:"Z122origenusuario",gxold:"O122origenusuario",gxvar:"A122origenusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A122origenusuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z122origenusuario=n)},v2c:function(n){gx.fn.setGridControlValue("ORIGENUSUARIO",n||gx.fn.currentGridRowImpl(84),gx.O.A122origenusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A122origenusuario=this.val())},val:function(n){return gx.fn.getGridControlValue("ORIGENUSUARIO",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[89]={lvl:2,type:"dtime",len:10,dec:8,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ORIGENFECREG",gxz:"Z124origenfecreg",gxold:"O124origenfecreg",gxvar:"A124origenfecreg",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A124origenfecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z124origenfecreg=gx.fn.toDatetimeValue(n))},v2c:function(n){gx.fn.setGridControlValue("ORIGENFECREG",n||gx.fn.currentGridRowImpl(84),gx.O.A124origenfecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A124origenfecreg=gx.fn.toDatetimeValue(this.val()))},val:function(n){return gx.fn.getGridDateTimeValue("ORIGENFECREG",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[90]={lvl:2,type:"dtime",len:10,dec:8,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ORIGENFECULTACT",gxz:"Z125origenfecultact",gxold:"O125origenfecultact",gxvar:"A125origenfecultact",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A125origenfecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z125origenfecultact=gx.fn.toDatetimeValue(n))},v2c:function(n){gx.fn.setGridControlValue("ORIGENFECULTACT",n||gx.fn.currentGridRowImpl(84),gx.O.A125origenfecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.A125origenfecultact=gx.fn.toDatetimeValue(this.val()))},val:function(n){return gx.fn.getGridDateTimeValue("ORIGENFECULTACT",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[91]={fld:"",grid:0};n[92]={fld:"",grid:0};this.AV6corigenid=0;this.ZV6corigenid=0;this.OV6corigenid=0;this.AV7corigendscorta="";this.ZV7corigendscorta="";this.OV7corigendscorta="";this.AV8corigendsclarga="";this.ZV8corigendsclarga="";this.OV8corigendsclarga="";this.AV9corigenusuario="";this.ZV9corigenusuario="";this.OV9corigenusuario="";this.AV10corigentotal="";this.ZV10corigentotal="";this.OV10corigentotal="";this.AV11corigenfecreg=gx.date.nullDate();this.ZV11corigenfecreg=gx.date.nullDate();this.OV11corigenfecreg=gx.date.nullDate();this.AV12corigenfecultact=gx.date.nullDate();this.ZV12corigenfecultact=gx.date.nullDate();this.OV12corigenfecultact=gx.date.nullDate();this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z10origenid=0;this.O10origenid=0;this.Z120origendscorta="";this.O120origendscorta="";this.Z122origenusuario="";this.O122origenusuario="";this.Z124origenfecreg=gx.date.nullDate();this.O124origenfecreg=gx.date.nullDate();this.Z125origenfecultact=gx.date.nullDate();this.O125origenfecultact=gx.date.nullDate();this.AV6corigenid=0;this.AV7corigendscorta="";this.AV8corigendsclarga="";this.AV9corigenusuario="";this.AV10corigentotal="";this.AV11corigenfecreg=gx.date.nullDate();this.AV12corigenfecultact=gx.date.nullDate();this.AV13porigenid=0;this.A123origentotal="";this.A121origendsclarga="";this.AV5LinkSelection="";this.A10origenid=0;this.A120origendscorta="";this.A122origenusuario="";this.A124origenfecreg=gx.date.nullDate();this.A125origenfecultact=gx.date.nullDate();this.Events={e210k2_client:["ENTER",!0],e220k1_client:["CANCEL",!0],e180k1_client:["'TOGGLE'",!1],e110k1_client:["LBLORIGENIDFILTER.CLICK",!1],e120k1_client:["LBLORIGENDSCORTAFILTER.CLICK",!1],e130k1_client:["LBLORIGENDSCLARGAFILTER.CLICK",!1],e140k1_client:["LBLORIGENUSUARIOFILTER.CLICK",!1],e150k1_client:["LBLORIGENTOTALFILTER.CLICK",!1],e160k1_client:["LBLORIGENFECREGFILTER.CLICK",!1],e170k1_client:["LBLORIGENFECULTACTFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6corigenid",fld:"vCORIGENID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7corigendscorta",fld:"vCORIGENDSCORTA",pic:"",nv:""},{av:"AV8corigendsclarga",fld:"vCORIGENDSCLARGA",pic:"",nv:""},{av:"AV9corigenusuario",fld:"vCORIGENUSUARIO",pic:"",nv:""},{av:"AV10corigentotal",fld:"vCORIGENTOTAL",pic:"",nv:""},{av:"AV11corigenfecreg",fld:"vCORIGENFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV12corigenfecultact",fld:"vCORIGENFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLORIGENIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ORIGENIDFILTERCONTAINER","Class")',ctrl:"ORIGENIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ORIGENIDFILTERCONTAINER","Class")',ctrl:"ORIGENIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCORIGENID","Visible")',ctrl:"vCORIGENID",prop:"Visible"}]];this.EvtParms["LBLORIGENDSCORTAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ORIGENDSCORTAFILTERCONTAINER","Class")',ctrl:"ORIGENDSCORTAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ORIGENDSCORTAFILTERCONTAINER","Class")',ctrl:"ORIGENDSCORTAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCORIGENDSCORTA","Visible")',ctrl:"vCORIGENDSCORTA",prop:"Visible"}]];this.EvtParms["LBLORIGENDSCLARGAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ORIGENDSCLARGAFILTERCONTAINER","Class")',ctrl:"ORIGENDSCLARGAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ORIGENDSCLARGAFILTERCONTAINER","Class")',ctrl:"ORIGENDSCLARGAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCORIGENDSCLARGA","Visible")',ctrl:"vCORIGENDSCLARGA",prop:"Visible"}]];this.EvtParms["LBLORIGENUSUARIOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ORIGENUSUARIOFILTERCONTAINER","Class")',ctrl:"ORIGENUSUARIOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ORIGENUSUARIOFILTERCONTAINER","Class")',ctrl:"ORIGENUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCORIGENUSUARIO","Visible")',ctrl:"vCORIGENUSUARIO",prop:"Visible"}]];this.EvtParms["LBLORIGENTOTALFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ORIGENTOTALFILTERCONTAINER","Class")',ctrl:"ORIGENTOTALFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ORIGENTOTALFILTERCONTAINER","Class")',ctrl:"ORIGENTOTALFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCORIGENTOTAL","Visible")',ctrl:"vCORIGENTOTAL",prop:"Visible"}]];this.EvtParms["LBLORIGENFECREGFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ORIGENFECREGFILTERCONTAINER","Class")',ctrl:"ORIGENFECREGFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ORIGENFECREGFILTERCONTAINER","Class")',ctrl:"ORIGENFECREGFILTERCONTAINER",prop:"Class"}]];this.EvtParms["LBLORIGENFECULTACTFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ORIGENFECULTACTFILTERCONTAINER","Class")',ctrl:"ORIGENFECULTACTFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ORIGENFECULTACTFILTERCONTAINER","Class")',ctrl:"ORIGENFECULTACTFILTERCONTAINER",prop:"Class"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A10origenid",fld:"ORIGENID",pic:"ZZZZZZZZZZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV13porigenid",fld:"vPORIGENID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6corigenid",fld:"vCORIGENID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7corigendscorta",fld:"vCORIGENDSCORTA",pic:"",nv:""},{av:"AV8corigendsclarga",fld:"vCORIGENDSCLARGA",pic:"",nv:""},{av:"AV9corigenusuario",fld:"vCORIGENUSUARIO",pic:"",nv:""},{av:"AV10corigentotal",fld:"vCORIGENTOTAL",pic:"",nv:""},{av:"AV11corigenfecreg",fld:"vCORIGENFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV12corigenfecultact",fld:"vCORIGENFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6corigenid",fld:"vCORIGENID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7corigendscorta",fld:"vCORIGENDSCORTA",pic:"",nv:""},{av:"AV8corigendsclarga",fld:"vCORIGENDSCLARGA",pic:"",nv:""},{av:"AV9corigenusuario",fld:"vCORIGENUSUARIO",pic:"",nv:""},{av:"AV10corigentotal",fld:"vCORIGENTOTAL",pic:"",nv:""},{av:"AV11corigenfecreg",fld:"vCORIGENFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV12corigenfecultact",fld:"vCORIGENFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6corigenid",fld:"vCORIGENID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7corigendscorta",fld:"vCORIGENDSCORTA",pic:"",nv:""},{av:"AV8corigendsclarga",fld:"vCORIGENDSCLARGA",pic:"",nv:""},{av:"AV9corigenusuario",fld:"vCORIGENUSUARIO",pic:"",nv:""},{av:"AV10corigentotal",fld:"vCORIGENTOTAL",pic:"",nv:""},{av:"AV11corigenfecreg",fld:"vCORIGENFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV12corigenfecultact",fld:"vCORIGENFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6corigenid",fld:"vCORIGENID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7corigendscorta",fld:"vCORIGENDSCORTA",pic:"",nv:""},{av:"AV8corigendsclarga",fld:"vCORIGENDSCLARGA",pic:"",nv:""},{av:"AV9corigenusuario",fld:"vCORIGENUSUARIO",pic:"",nv:""},{av:"AV10corigentotal",fld:"vCORIGENTOTAL",pic:"",nv:""},{av:"AV11corigenfecreg",fld:"vCORIGENFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV12corigenfecultact",fld:"vCORIGENFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.setVCMap("AV13porigenid","vPORIGENID",0,"int");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar(this.GXValidFnc[66]);t.addRefreshingVar(this.GXValidFnc[76]);this.InitStandaloneVars()});gx.createParentObj(gx00g0)