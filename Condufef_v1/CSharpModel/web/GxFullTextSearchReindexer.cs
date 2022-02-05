/*
               File: GxFullTextSearchReindexer
        Description: No description for object
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/4/2022 20:17:5.41
       Program type: Callable routine
          Main DBMS: postgresql
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using GeneXus.Data;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class GxFullTextSearchReindexer
   {
      public static int Reindex( IGxContext context )
      {
         GxSilentTrnSdt obj ;
         IGxSilentTrn trn ;
         bool result ;
         obj = new Sdtalmacen(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new Sdtempleadospiso(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new Sdtempleados(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new Sdtproveedores(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new Sdtstatus(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new Sdttipodocumento(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new Sdtmodelos(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new Sdtarea(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new Sdtorigen(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new Sdtcambs(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new Sdtproducto(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new Sdtmarcas(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new Sdtestatusarticulo(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new Sdtcategorias(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new Sdtentidadfederativa(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new Sdttipobien(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         return 1 ;
      }

   }

}
