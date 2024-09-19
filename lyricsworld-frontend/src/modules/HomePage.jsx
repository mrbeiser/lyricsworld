import { Link } from 'react-router-dom'
import Header from './Header'
function HomePage() {
  
    return (
      <div className="App">
        <Header />
        <main>
          <h1>LyricsWorld</h1>
          <h2>Music, the Coolest Language of All</h2>
          <Link to="/songs" id="link">Start Searching</Link>
       
        </main> 
       
      </div>
    )
}
export default HomePage