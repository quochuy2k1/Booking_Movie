export interface IConditionChartFilter{
    conditional?: number;
    token?: string
}

export interface IUserAuthentication{
    lastName: string,
    firstName: string,
    userName: string,
    roles: string[],
    isLogin: boolean
} 