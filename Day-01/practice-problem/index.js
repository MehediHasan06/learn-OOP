import * as d3 from 'd3'
import { readFileSync } from 'fs'

try {
    // 1. Read the CSV file
    const csvData = readFileSync('salarysheet.csv', 'utf-8');

    // 2. Extract the CSV data
    const rows = csvData.trim().split('\n'); //[ 'Dolon,45000\r', 'Rafi,34000\r' ... ]
    const data = rows.map((row) => {
        const columns = row.split(','); //[ 'Dolon', '45000\r' ] 
        const [name, salary] = columns.map(col => col.trim()); 
        return { 
            name,
            salary: +salary || 0 // Convert to number, default to 0 if invalid
        };
    })
    /**
     * data -> a array of objects.
     * [
            { name: 'Dolon', salary: 45000 },
            { name: 'Rafi', salary: 34000 },
            { name: 'Hasan', salary: 56000 },
            { name: 'Salma', salary: 45000 }
        ]
    */

    // 3. Process the data
    const maxSalary = d3.max(data, d => d.salary);
    const personWithMaxSalary = data.find(d => d.salary === maxSalary);

    const minSalary = d3.min(data, d => d.salary);
    const personWithMinSalary = data.find(d => d.salary === minSalary);

    const avgSalary = d3.mean(data, d => d.salary);

    console.log(`Maximum Salary: ${personWithMaxSalary.name} (${maxSalary})`);
    console.log(`Minimum Salary: ${personWithMinSalary.name} (${minSalary})`);
    console.log(`Average Salary: ${avgSalary.toFixed(2)}`);
} catch (error) {
    console.error('Error reading or processing the CSV file:', error.message);
}