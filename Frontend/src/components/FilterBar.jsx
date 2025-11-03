import "../styles/FilterBar.css";

function FilterBar({ priceFilter, descriptionFilter, setPriceFilter, setDescriptionFilter }) {
  return (
    <>
      <input
        type="number"
        placeholder="Max Price"
        value={priceFilter}
        onChange={(e) => setPriceFilter(e.target.value)}
        className="filter-input"
      />
      <input
        type="text"
        placeholder="Filter by Description"
        value={descriptionFilter}
        onChange={(e) => setDescriptionFilter(e.target.value)}
        className="filter-input"
      />
    </>
  );
}

export default FilterBar;