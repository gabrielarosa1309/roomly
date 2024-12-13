import axios from "axios";

/**
 * Rota para o recurso Login
 */
export const loginResource = '/Login';

const apiPort = '7091';
const localApiUri = `https://localhost:${apiPort}/api`;

const api = axios.create({
    baseURL: externalApiUri
});

export default api;