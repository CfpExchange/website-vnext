import './header.css';

function Header(){
	return (
		<header>
			<nav className="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">
				<div className="container-fluid justify-content-center">
					<a className="navbar-brand ms-2" href="/">CFP E<img src="/images/exchange-small.png" className="brand-img" alt="x"/>change</a>
					<button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavDropdown"
						aria-controls="navbarNavDropdown" aria-expanded="true" aria-label="Toggle navigation">
						<span className="navbar-toggler-icon"></span>
					</button>
					<div className="collapse navbar-collapse justify-content-center" id="navbarNavDropdown">
						<div className="navbar-nav">
							<a className="nav-link" href="/">Home</a>
							<a className="nav-link" href="/cfps">CFPs</a>
							<a className="nav-link" href="/contact">Contact</a>
							<a className="nav-link" href="/about">About</a>
						</div>
					</div>
				</div>
			</nav>
		</header> 
	);
}

export default Header;