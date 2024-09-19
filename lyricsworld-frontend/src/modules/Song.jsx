import React, { useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { useNavigate, useParams } from "react-router-dom";
import css from "../cssformodules/OneSongModule.module.css";
import { oneSong } from "../store/state/OneSong";
import Header from "./Header";

function Song() {
  const navigate = useNavigate();
  const { id } = useParams();
  const dispatch = useDispatch();

  useEffect(() => {
    dispatch(oneSong(id));
  }, []);
  const song = useSelector((state) => state.Song);

  const divideLyrics = (lyricsstring) => {
    try {
      let tempList = lyricsstring.split("|");
      return tempList.map((lyrics) => (
        <div className={css.lyricsLines} key={Math.random()}>
          {lyrics}
          <br />
        </div>
      ));
    } catch {
      return lyricsstring;
    }
  };

  const songDurationToMins = (duration) => {
    let s = duration % 60;
    if (s < 10) {
      s = "0" + s;
    }
    let m = (duration - s) / 60;
    return m + ":" + s;
  };

  return (
    <div className={css.songBox}>
      <Header />
      <div
        onClick={() => {
          navigate("/songs");
        }}
        className="back"
      >
        back
      </div>{" "}
      <h1 className={css.songTitle}>{song.data.songTitle}</h1>
      <p>Song duration: {songDurationToMins(song.data.songDuration)}</p>
      <section className={css.lyricsBox}>
        {divideLyrics(song.data.songLyrics)}
      </section>
    </div>
  );
}

export default Song;
