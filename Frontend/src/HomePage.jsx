import { useEffect, useState } from "react";
import { getItems } from "./services/api";
import ItemCard from "./components/ItemCard";
import FilterBar from "./components/FilterBar";
import "./styles/HomePage.css";

function HomePage() {
  const [items, setItems] = useState([]);
  const [filtered, setFiltered] = useState([]);
  const [priceFilter, setPriceFilter] = useState("");
  const [descriptionFilter, setDescriptionFilter] = useState("");

  // Fetch data once
  useEffect(() => {
    getItems()
      .then((data) => {
        console.log("Fetched data:", data);
        setItems(data);
        setFiltered(data);
      })
      .catch((err) => console.error("Error fetching:", err));
  }, []);

  // Apply filters
  useEffect(() => {
    let data = [...items];

    // Price filter
    if (priceFilter) {
      const max = parseFloat(priceFilter);
      if (!isNaN(max)) data = data.filter((item) => item.price <= max);
    }

    // Description filter
    if (descriptionFilter) {
      data = data.filter((item) =>
        (item.description || "")
          .toLowerCase()
          .includes(descriptionFilter.toLowerCase())
      );
    }

    setFiltered(data);
  }, [priceFilter, descriptionFilter, items]);

  return (
    <div className="home-container">
      <h1 className="title">Peripheral Store</h1>
      <div className="filter-bar">
        <FilterBar
          priceFilter={priceFilter}
          descriptionFilter={descriptionFilter}
          setPriceFilter={setPriceFilter}
          setDescriptionFilter={setDescriptionFilter}
        />
      </div>

      <div className="item-grid">
        {filtered.map((item) => (
          <ItemCard key={item.id} item={item} />
        ))}

        {filtered.length === 0 && (
          <p className="no-items">No items found for this filter.</p>
        )}
      </div>
    </div>
  );
}

export default HomePage;