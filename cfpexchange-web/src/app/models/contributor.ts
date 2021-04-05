export class Contributor {
	public login: string | undefined;
	public id: Number = -1;
	public node_id: string | undefined;
	public avatar_url: string | undefined;
	public gravatar_id: string | undefined;
	public url: string | undefined;
	public html_url: string | undefined;
	public followers_url: string | undefined;
	public following_url: string | undefined;
	public gists_url: string | undefined;
	public starred_url: string | undefined;
	public subscriptions_url: string | undefined;
	public organizations_url: string | undefined;
	public repos_url: string | undefined;
	public events_url: string | undefined;
	public received_events_url: string | undefined;
	public type: string | undefined;
	public site_admin: boolean = false;
	public contributions: Number = -1;
}