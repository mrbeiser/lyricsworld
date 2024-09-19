import React from "react";
import { useSelector,useDispatch } from 'react-redux';
import {getArtists} from '../store/state/ArtistsList'
import { useEffect } from "react";
    
    

function Artist() {
    const dispatch1 = useDispatch()
    useEffect(()=>{dispatch1(getArtists())},[])
    const artist = useSelector((state) => state.Artist)

    console.log(artist)
    return (
        <div>
            <ul>{artist.data.map((artist) => <li key={artist.id}>{artist.name}</li>)}</ul>
        </div>
    );
}

export default Artist

