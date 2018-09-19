import axios from 'axios';

export const getEmployees = id =>
    axios.get(`http://localhost:62815/api/employees${id > 0 ? '/' + id : ''}`).then(data => {
        return data;
    })