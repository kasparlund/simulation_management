namespace VSM.Client.Datamodel
{
    using MongoDB.Bson; //due to ObjectId

    public class ProductDetails
    {
        public ObjectId _id { get; set; }
        public double amount { get; set; } = 0.0;
        //public string id { get; set; } = string.Empty;
        public string f1 { get; set; } = string.Empty;
        public string f2 { get; set; } = string.Empty;
        public string f3 { get; set; } = string.Empty;
        public string f4 { get; set; } = string.Empty;
        public string f5 { get; set; } = string.Empty;
        public string f6 { get; set; } = string.Empty;
        public string f7 { get; set; } = string.Empty;
        public string f8 { get; set; } = string.Empty;
        public string f9 { get; set; } = string.Empty;
        public string f10 { get; set; } = string.Empty;
        public string f11 { get; set; } = string.Empty;
        public string f12 { get; set; } = string.Empty;
        public string f13 { get; set; } = string.Empty;
        public string f14 { get; set; } = string.Empty;
        public string f15 { get; set; } = string.Empty;
        public string f16 { get; set; } = string.Empty;
        public string f17 { get; set; } = string.Empty;
        public string f18 { get; set; } = string.Empty;
        public string f19 { get; set; } = string.Empty;
        public string f20 { get; set; } = string.Empty;
        public string f21 { get; set; } = string.Empty;
        public string f22 { get; set; } = string.Empty;
        public string f23 { get; set; } = string.Empty;
        public string f24 { get; set; } = string.Empty;
        public string f25 { get; set; } = string.Empty;
        public string f26 { get; set; } = string.Empty;
        public string f27 { get; set; } = string.Empty;
        public string f28 { get; set; } = string.Empty;
        public string f29 { get; set; } = string.Empty;
        public string f30 { get; set; } = string.Empty;
        public int year { get; set; } = 0;

        public static List<string> generate_random_from_list(int seed, int number_of_values, List<string> source)
        {
            List<string> values = new List<string>();
            Random rand = new(seed);
            int upper = source.Count;
            for (int j = 0; j < number_of_values; j++)
                values.Add(source[rand.Next(upper)]);
            return values;
        }

        public static List<ProductDetails> GetProductData()
        {
            //List<string> fl1   = new List<string> { "France", "Germany", "United States" };
            //List<string> fl2   = new List<string> { "Mountain Bikes", "Road Bikes", "Racer" };
            List<string> fl1 = new List<string> {
            "Afghanistan","Albania","Algeria","Andorra","Angola","Antigua & Deps","Argentina","Armenia","Australia","Austria","Azerbaijan","Bahamas","Bahrain","Bangladesh","Barbados","Belarus","Belgium","Belize","Benin","Bhutan","Bolivia","Bosnia Herzegovina","Botswana","Brazil","Brunei","Bulgaria","Burkina","Burundi","Cambodia","Cameroon","Canada","Cape Verde","Central African Rep","Chad","Chile","China","Colombia","Comoros","Congo","Congo {Democratic Rep}","Costa Rica","Croatia","Cuba","Cyprus","Czech Republic","Denmark","Djibouti","Dominica","Dominican Republic","East Timor","Ecuador","Egypt","El Salvador","Equatorial Guinea","Eritrea","Estonia","Ethiopia","Fiji","Finland","France","Gabon","Gambia","Georgia","Germany","Ghana","Greece","Grenada","Guatemala","Guinea","Guinea-Bissau","Guyana","Haiti","Honduras","Hungary","Iceland","India","Indonesia","Iran","Iraq","Ireland {Republic}","Israel","Italy","Ivory Coast","Jamaica","Japan","Jordan","Kazakhstan","Kenya","Kiribati","Korea North","Korea South","Kosovo","Kuwait","Kyrgyzstan","Laos","Latvia","Lebanon","Lesotho","Liberia","Libya","Liechtenstein","Lithuania","Luxembourg","Macedonia","Madagascar","Malawi","Malaysia","Maldives","Mali","Malta","Marshall Islands","Mauritania","Mauritius","Mexico","Micronesia","Moldova","Monaco","Mongolia","Montenegro","Morocco","Mozambique","Myanmar, {Burma}","Namibia","Nauru","Nepal","Netherlands","New Zealand","Nicaragua","Niger","Nigeria","Norway","Oman","Pakistan","Palau","Panama","Papua New Guinea","Paraguay","Peru","Philippines","Poland","Portugal","Qatar","Romania","Russian Federation","Rwanda","St Kitts & Nevis","St Lucia","Saint Vincent & the Grenadines","Samoa","San Marino","Sao Tome & Principe","Saudi Arabia","Senegal","Serbia","Seychelles","Sierra Leone","Singapore","Slovakia","Slovenia","Solomon Islands","Somalia","South Africa","South Sudan","Spain","Sri Lanka","Sudan","Suriname","Swaziland","Sweden","Switzerland","Syria","Taiwan","Tajikistan","Tanzania","Thailand","Togo","Tonga","Trinidad & Tobago","Tunisia","Turkey","Turkmenistan","Tuvalu","Uganda","Ukraine","United Arab Emirates","United Kingdom","United States","Uruguay","Uzbekistan","Vanuatu","Vatican City","Venezuela","Vietnam","Yemen","Zambia","Zimbabwe"
        };
            List<string> fl2 = new List<string> {
            "AF","AL","DZ","AS","AD","AO","AI","AQ","AG","AR","AM","AW","AU","AT","AZ","BS","BH","BD","BB","BY","BE","BZ","BJ","BM","BT","BO","BA","BW","BV","BR","IO","BN","BG","BF","BI","CV","KH","CM","CA","KY","CF","TD","CL","CN","CX","CC","CO","KM","CG","CD","CK","CR","CI","HR","CU","CW","CY","CZ","DK","DJ","DM","DO","EC","EG","SV","GQ","ER","EE","ET","FK","FO","FJ","FI","FR","GF","PF","TF","GA","GM","GE","DE","GH","GI","GR","GL","GD","GP","GU","GT","GG","GN","GW","GY","HT","HM","VA","HN","HK","HU","IS","IN","ID","IR","IQ","IE","IM","IL","IT","JM","JP","JE","JO","KZ","KE","KI","KP","KR","KW","KG","LA","LV","LB","LS","LR","LY","LI","LT","LU","MO","MK","MG","MW","MY","MV","ML","MT","MH","MQ","MR","MU","YT","MX","FM","MD","MC","MN","ME","MS","MA","MZ","MM","NA","NR","NP","NL","NC","NZ","NI","NE","NG","NU","NF","MP","NO","OM","PK","PW","PS","PA","PG","PY","PE","PH","PN","PL","PT","PR","QA","RE","RO","RU","RW","BL","SH","KN","LC","MF","PM","VC","WS","SM","ST","SA","SN","RS","SC","SL","SG","SX","SK","SI","SB","SO","ZA","GS","SS","ES","LK","SD","SR","SJ","SZ","SE","CH","SY","TW","TJ","TZ","TH","TL","TG","TK","TO","TT","TN","TR","TM","TC","TV","UG","UA","AE","GB","US","UM","UY","UZ","VU","VE"
        };
            List<string> fl3 = new List<string> { "crank", "pedal", "handlebar" };
            List<string> years = new List<string> { "2015", "2016", "2017", "2018" };

            List<ProductDetails> productData = new List<ProductDetails>();
            int min_cardinality = 50_000;
            Random r = new(10);
            int row_count = 100_000;
            for (int i = 0; i <= row_count; i++)
                productData.Add(
                    new ProductDetails
                    {
                        f1 = fl1[r.Next(fl1.Count)],
                        f2 = fl2[r.Next(fl2.Count)] + " - " + r.Next(min_cardinality),
                        f3 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.95 * min_cardinality)),
                        f4 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.90 * min_cardinality)),
                        f5 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.85 * min_cardinality)),
                        f6 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.80 * min_cardinality)),
                        f7 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.75 * min_cardinality)),
                        f8 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.70 * min_cardinality)),
                        f9 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.65 * min_cardinality)),
                        f10 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.60 * min_cardinality)),
                        f11 = fl1[r.Next(fl1.Count)] + " - " + r.Next((int)(0.50 * min_cardinality)),
                        f12 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.40 * min_cardinality)),
                        f13 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.35 * min_cardinality)),
                        f14 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.30 * min_cardinality)),
                        f15 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.25 * min_cardinality)),
                        f16 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.20 * min_cardinality)),
                        f17 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.15 * min_cardinality)),
                        f18 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.10 * min_cardinality)),
                        f19 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.05 * min_cardinality)),
                        f20 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.05 * min_cardinality)),
                        f21 = fl1[r.Next(fl1.Count)] + " - " + r.Next((int)(0.25 * min_cardinality)),
                        f22 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.25 * min_cardinality)),
                        f23 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.15 * min_cardinality)),
                        f24 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.15 * min_cardinality)),
                        f25 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.10 * min_cardinality)),
                        f26 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.05 * min_cardinality)),
                        f27 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.05 * min_cardinality)),
                        f28 = fl2[r.Next(fl2.Count)] + " - " + r.Next((int)(0.01 * min_cardinality)),
                        f29 = fl2[r.Next(fl2.Count)] + " - " + r.Next(min_cardinality),
                        f30 = fl3[r.Next(fl3.Count)],
                        //year = years[r.Next(years.Count)]
                    }
                );

            return productData;
        }
    }

}