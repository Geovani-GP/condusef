/**@preserve  GeneXus C# 10_3_15-115824 on 1/22/2022 13:27:3.62
*/
gx.evt.autoSkip=!1;gx.define("recentlinks",!0,function(n){var i,t;this.ServerClass="recentlinks";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV6FormCaption=gx.fn.getControlValue("vFORMCAPTION");this.AV7FormPgmName=gx.fn.getControlValue("vFORMPGMNAME")};this.e13022_client=function(){this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e14022_client=function(){this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];i=this.GXValidFnc;this.GXCtrlIds=[2,5,10,12,14];this.GXLastCtrlId=14;this.LinksContainer=new gx.grid.grid(this,2,"WbpLvl2",7,"Links","Links","LinksContainer",this.CmpContext,this.IsMasterPage,"recentlinks",[],!0,0,!0,!0,0,!1,!1,!1,"",0,"px","Nueva fila",!1,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.LinksContainer;t.startRow("","","","","","");t.startCell("","","","","","","37px","","","");t.addTextBlock("PLACE",null);t.endCell();t.startCell("","","","","","","4px","","","td100");t.addTextBlock("PIPE",null);t.endCell();t.endRow();this.setGrid(t);i[2]={fld:"TABLE",grid:0};i[5]={fld:"RECENTTEXT",format:0,grid:0};i[10]={fld:"PLACE",format:0,grid:7};i[12]={fld:"PIPE",format:0,grid:7};i[14]={fld:"BOTTOMLINE",grid:0};this.AV6FormCaption="";this.AV7FormPgmName="";this.Events={e13022_client:["ENTER",!0],e14022_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"LINKS_nFirstRecordOnPage",nv:0},{av:"LINKS_nEOF",nv:0},{av:"AV6FormCaption",fld:"vFORMCAPTION",pic:"",nv:""},{av:"sPrefix",nv:""}],[]];this.EvtParms["LINKS.LOAD"]=[[{av:"AV6FormCaption",fld:"vFORMCAPTION",pic:"",nv:""}],[{av:'gx.fn.getCtrlProperty("PLACE","Caption")',ctrl:"PLACE",prop:"Caption"},{av:'gx.fn.getCtrlProperty("PLACE","Link")',ctrl:"PLACE",prop:"Link"}]];this.setVCMap("AV6FormCaption","vFORMCAPTION",0,"char");this.setVCMap("AV7FormPgmName","vFORMPGMNAME",0,"svchar");this.setVCMap("AV6FormCaption","vFORMCAPTION",0,"char");t.addRefreshingVar({rfrVar:"AV6FormCaption"});this.InitStandaloneVars()})