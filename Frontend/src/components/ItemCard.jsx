import "../styles/ItemCard.css";
 
function ItemCard({ item }) {
  return (
    <div className="item-card">
      <img src={item.url} alt={item.name} className="item-image" />
      <h2 className="item-name">{item.name}</h2>
      <p className="item-desc">{item.description}</p>
      <p className="item-price">₹{item.price}</p>
      <p className="item-qty">Qty: {item.quantity}</p>
    </div>
  );
}
 
export default ItemCard;