using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta5
{
    public static class ResultSets
    {
        public static Result Action01() {
            return new Successed();
        }

        public static Result Action02()
        {
            return new Successed("işlem başarılı tamamlandı");
        }

        public static Result Action03()
        {
            return new Failed();
        }

        public static Result Action04()
        {
            return new Failed("İşlem başarısız oldu");
        }

 
    }
}
