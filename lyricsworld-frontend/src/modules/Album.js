import React from "react";
import { useSelector,useDispatch } from 'react-redux';
import {getAlbums} from '../store/state/AlbumList'
import { useEffect } from "react";
    

    function Album(){
        const dispatch = useDispatch()
        useEffect(()=>{dispatch(getAlbums())},[])
        const album = useSelector((state) => state.Album)
        const albumItems = album.data.map((album) => <li key={album.albumID}>{album.albumTitle}</li>);
        return (
            <div>
                 <ul>{albumItems}</ul>
            </div>
        );
}

export default Album

