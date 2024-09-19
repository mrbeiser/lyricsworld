import { useDispatch, useSelector } from "react-redux";
import { useEffect } from "react";
import {getAllFromConnect} from '../store/state/Connect.js'


export default function AllData()
{
    const dispatch = useDispatch();
    const alldata = useSelector((state) => state.ConnectDB) 
    useEffect(()=> {dispatch(getAllFromConnect())}, [])
    const selected = alldata.data.map((conn) => <article key={conn.ConnID}>{conn.song.songTitle}{conn.song.songLyrics}<br />{conn.album.albumTitle}<br/>{conn.artist.name}<br/><br/><br/><br/></article>);

    return(
        <div>
            {selected}
        </div>

    )
}

