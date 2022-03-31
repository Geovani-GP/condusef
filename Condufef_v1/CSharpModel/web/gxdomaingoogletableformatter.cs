/*
               File: GoogleTableFormatter
        Description: GoogleTableFormatter
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 3/31/2022 0:20:5.92
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
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class gxdomaingoogletableformatter
   {
      private static Hashtable domain = new Hashtable();
      static gxdomaingoogletableformatter ()
      {
         domain["arrow"] = "Arrow";
         domain["bar"] = "Bar";
         domain["color"] = "Color";
         domain["number"] = "Number";
         domain["pattern"] = "Pattern";
      }

      public static string getDescription( IGxContext context ,
                                           String key )
      {
         string rtkey ;
         rtkey = StringUtil.Trim( (String)(key));
         return (string)domain[rtkey] ;
      }

      public static GxSimpleCollection getValues( )
      {
         GxSimpleCollection value = new GxSimpleCollection();
         ArrayList aKeys = new ArrayList(domain.Keys);
         aKeys.Sort();
         foreach (String key in aKeys)
         {
            value.Add(key);
         }
         return value;
      }

   }

}
