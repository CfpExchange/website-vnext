import './footer.css';

function Footer(){
	return (
		<footer className="fixed-bottom bg-dark py-3">
			<div className="container">
				<div className="container text-center">
					<div className="row">
						<div className="col-3 text-start">
							<h5>Follow us!</h5>
							<a href="https://twitter.com/cfp_exchange" target="_blank" rel="noopener noreferrer"><i
									className="fab fa-twitter"></i> Twitter</a><br />
							<a href="https://github.com/cfpexchange/website-vnext" target="_blank" rel="noopener noreferrer"><i
									className="fab fa-github"></i> GitHub</a><br />
							<a href="https://cfp.exchange/api/rss" target="_blank" rel="noopener noreferrer"><i className="fas fa-rss"></i> RSS
								feed</a>
						</div>
						<div className="col-6">
							<h5>About</h5>
							CFP Exchange tries to gather current CFPs from events around the world by crowd-sourcing them from
							the community.
						</div>
						<div className="col-3 text-end">
							<h5>Submit</h5>
							<a href="/submit" className="btn btn-light"><i className="far fa-paper-plane"></i> Submit CFP</a>
						</div>
					</div>
					<div className="row mt-3">
						<div className="col">
							made with <i className="fas fa-heart"></i> &mdash; copyright &copy; 2021 <a href="/">CFP Exchange - Crowd-sourced CFP list</a></div>
					</div>
				</div>
			</div>
		</footer>
	);
}

export default Footer;