namespace frequenSee.Engine.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using frequenSee.Engine;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using frequenSee.Models;

    [TestClass()]
    public class SymbolDigesterTests
    {
        [TestMethod()]
        public void DigestInputTest()
        {
            string input = "Ընկերությունը անգին գանձ է։ Այն նման չէ թանկարժեք ծաղկամանի, որն օգտագործվում է պարզապես դեկորացիայի համար։ Ընկերությունն ավելի շատ նման է գեղեցիկ ծաղկի, որին անհրաժեշտ է ջուր և խնամք, որպեսզի շարունակ փարթամանա ու ծաղկի։ Աբրահամը թանկ էր գնահատում Եհովայի հետ իր ընկերությունը և ամեն բան անում էր այն պահպանելու համար։ Իսկ ինչպե՞ս։ Աբրահամը երբեք չմտածեց, թե բավական է՝ ինչքան աստվածավախություն և հնազանդություն է դրսևորել։ Երբ նա իր մեծ ընտանիքով ճամփորդում էր դեպի Քանան, շարունակում էր հետևել Եհովայի առաջնորդությանը իր բոլոր որոշումներում՝ մեծ թե փոքր։ Իսահակի ծնվելուց մեկ տարի առաջ, երբ Աբրահամը 99 տարեկան էր, Եհովան պահանջեց, որ նրա տան բոլոր տղամարդիկ թլփատվեն։ Արդյո՞ք Աբրահամը հարցականի տակ դրեց այդ պատվերը կամ արդարացում գտավ չհնազանդվելու համար։ Ո՛չ, նա վստահեց Եհովային և «հենց նույն օրը» նրա ասածի պես արեց";

            SymbolFrequencyResultSet result = frequenSee.Engine.SymbolDigester.DigestInput(input);

            StringBuilder resultString = new StringBuilder();

            foreach(var symbol in result.SymbolDictionary)
            {
                resultString.AppendLine($"{symbol.Value.Symbol.Symbol}: {symbol.Value.Hits}");
            }

            Assert.IsNotNull(result);
        }
    }
}