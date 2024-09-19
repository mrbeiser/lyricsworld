import Header from './Header'
import css from '../cssformodules/SongsPage.module.css'
import { useState } from 'react'
import {search, clearSongs} from '../store/state/SongSearchSlice'
import { useDispatch, useSelector } from 'react-redux';
import { useNavigate } from 'react-router-dom';
function SongsPage(){

    const navigate = useNavigate()

    const [value, setValue] = useState('');
    const dispatch = useDispatch()
    const song = useSelector((state) => state.Search)
    
    
    const handleChange = (e) =>     
    {
        let newvalue = e.target.value
        setValue(newvalue)
        if(newvalue.length > 0){ dispatch(search(newvalue)) }
        else(dispatch(clearSongs()))
    }

    const handleButton = (songid) => 
    {
        navigate(`/song/`+songid)
    }

    const songList = () => 
    {
        return song.songs.map((song) => <article className={css.list} key={song.songID}>{song.songTitle} <button className={css.viewbutton} onClick={() => handleButton(song.songID)}>View</button></article>)
    }
    return(
        <div id={css.pagecontainer}>
            <Header />
            <main>
                <input type='text' name="search" id={css.search} placeholder="Search for songs..." value={value} onChange={handleChange}></input>
                <div className={css.articlecontainer}>{songList()}</div>
            </main>
        </div>
    )
}

export default SongsPage