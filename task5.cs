namespace classtutorial
{
    public class Cart
    {
        private items Item = new items();
        public Cart addItem(int id, int price, int qty = 1){
            Item.Item_id = id;
            Item.Price = price;
            Item.Quantity = qty;
            return this;
        }
        // public Cart removeItem(int id){
        //     // return this;
        // }
        // public Cart addDiscount(string discount){
        //     // return this;
        // }
        
        // public int totalItems(){
        //     return 
        // }
    }
    
    public class items{
        public int Item_id{get; set;}
        public int Price{get; set;}
        public int Quantity{get; set;}
    }
}