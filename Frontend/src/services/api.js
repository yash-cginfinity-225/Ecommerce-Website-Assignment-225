import axios from "axios";

const API = axios.create({
  baseURL: "https://localhost:7111/api",
});

export const getItems = async () => {
  const response = await API.get("/ItemData");
  return response.data;
};