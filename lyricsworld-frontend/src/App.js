import './App.css';
import Album from './modules/Album'
import RegisterPage from './modules/RegisterPage'
import HomePage from './modules/HomePage'
import Profile from './modules/Profile'
import LoginPage from './modules/LoginPage'
import Artist from './modules/Artist'
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import SongsPage from './modules/SongsPage'
import Song from './modules/Song'
import AllData from './modules/AllData';
function App() {
  

  return (
    <Router>
    <Routes>
      <Route exact path='/' element={<HomePage />} />
      <Route exact path='/register' element={<RegisterPage />} />
      <Route exact path='/login' element={<LoginPage/>} />
      <Route exact path='/profile' element={<Profile />} /> 
      <Route exact path='/albums' element={<Album />} /> 
      <Route exact path='/artists' element={<Artist />} /> 
      <Route exact path='/songs' element={<SongsPage />} /> 
      <Route exact path='/allData' element={<AllData />} /> 
      <Route path='/song/:id' element={<Song/>} />
      
    </Routes>
    </Router>
  );
}

export default App;
