// Async await
import axios from 'axios';

async function fetchData(url: string): Promise<void> {
    try {
        const response = await axios.get(url);
        console.log(response.data);
    } catch (error) {
        console.error('Error:', error);
    }
}

const url = 'https://jsonplaceholder.typicode.com/posts';
fetchData(url);

