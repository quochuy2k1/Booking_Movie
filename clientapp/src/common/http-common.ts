import axios from "axios";
const url = `${import.meta.env.VITE_REACT_APP_API_BASE!}`

export default axios.create({
    baseURL: url,
    headers: {
        'Content-Type': 'application/json',
        'Accept': 'application/json',
        'WithCredentials': "true",
        // 'CrossOrigin': "true",
        'Mode': 'cors',
    }
});

