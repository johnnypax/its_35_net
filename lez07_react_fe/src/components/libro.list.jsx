import { useEffect, useState } from "react";

function LibroList() {

    const [libri, setLibri] = useState([]);

    async function getLibri() {
        try {
            const response = await fetch('https://localhost:7140/api/libri');
            const data = await response.json();
            setLibri(data);
        } catch (error) {
            console.error('Error fetching libri:', error);
        }        
    }

    async function deleteLibro(id) {
        try {
            await fetch(`https://localhost:7140/api/libri/${id}`, {
                method: 'DELETE'
            });
            getLibri(); // Refresh the list after deletion
        } catch (error) {
            console.error('Error deleting libro:', error);
        }
    }

    useEffect(() => {
        getLibri();
    }, []);


    return (
        <>
            <h1>Elenco libri</h1>

            <table className="table">
                <thead>
                    <tr>
                        <th>Titolo</th>
                        <th>Descrizione</th>
                        <th>Autore</th>
                        <th>Anno</th>
                    </tr>
                </thead>
                <tbody>
                    {libri.map((l) => (
                        <tr key={l.id}>
                            <td>{l.titolo}</td>
                            <td>{l.descrizione}</td>
                            <td>{l.autore}</td>
                            <td>{l.anno}</td>
                            <td>
                                <button className="btn btn-primary">Modifica</button>
                                <button 
                                    className="btn btn-danger"
                                    onClick={() => deleteLibro(l.id)}>Elimina</button>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </>
    );
}

export default LibroList;