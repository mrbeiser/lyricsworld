import axios from "axios";

const api = axios;
api.defaults.headers.common['Content-Type'] = 'application/json'
api.defaults.headers.common['Authorization'] = 'Bearer '+localStorage.getItem('token')
export const baseURL = "http://localhost:5159/api"

export default api

